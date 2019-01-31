using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using System.Timers;
using DataAdaptor;

namespace UI
{
    public partial class BarKeukenForm : Form
    {
        private List<BestellingsitemModel> Bestellingen = new List<BestellingsitemModel>(); //List with all orders that have to be shown
        private BestellingsItemService bestellingLogica;
        private WerknemerModel werknemer;
        private delegate void CreateTimerCallback(); //Callback for invoking from the timer thread
        private System.Timers.Timer timer;
        private BarKeukenHeader header;

        public BarKeukenForm(WerknemerModel werknemer)
        {
            InitializeComponent();
            this.werknemer = werknemer;

            if(werknemer.Functie==Functie.Bar)
            {
                header = new BarKeukenHeader(LogOut, ShowOrders, false); //initialize the header with false (indicates this isn't a kitchen)
            }
            else
            {
                header = new BarKeukenHeader(LogOut, ShowOrders, true); //initialize the header with true (indicates this is a kitchen)
            }
            
            bestellingLogica = new BestellingsItemService();
            //Get all currently open orders
            try
            {
                Bestellingen = bestellingLogica.GetBestellingsitems(werknemer);
            }catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitialiseTimer();
            BouwUI();
        }

        
        private void BouwUI()
        {
            if(this.InvokeRequired)//Check if we're calling from a different thread
            {
                //if so invoke the method from a delegate instead
                CreateTimerCallback cb = new CreateTimerCallback(BouwUI);
                this.Invoke(cb);
            }
            else
            {
                Controls.Clear();
                Panel ItemLijstContainer = new Panel() { Top = 60, AutoScroll = true, Width = 1600, Height = 715 };
                int y = 0;
                foreach (BestellingsitemModel b in Bestellingen)
                {
                    BarKeukenUIElement uiElement = new BarKeukenUIElement(b, bestellingLogica, (item) => { Bestellingen.Remove(item); BouwUI(); })
                        { Top = y};
                    if(b.Status==BestellingsItemStatus.gereed|| b.Status == BestellingsItemStatus.afgeleverd)
                    {
                        uiElement.StyleAsFinished();
                    }
                    ItemLijstContainer.Controls.Add(uiElement);
                    y += uiElement.Height + 5;
                }
                Controls.Add(header);
                Controls.Add(ItemLijstContainer);
            }
            
        }

        private void LogOut()
        {
            new Login().Show();
            this.Hide();
        }

        private void ShowOrders(bool showCurrentOrdersOnly)
        {
            if(showCurrentOrdersOnly)
            {
                timer.Start();
                try
                {
                    Bestellingen = bestellingLogica.GetBestellingsitems(werknemer);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BouwUI();
            }
            else
            {
                timer.Stop();
                try
                {
                    Bestellingen = bestellingLogica.GetAlleBestellingenVanVandaag(werknemer);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BouwUI();
            }
        }

        private void InitialiseTimer()
        {
            timer = new System.Timers.Timer { Interval = 60000 }; //1 minute
            timer.Elapsed += (s, e) => {
                try
                {
                    Bestellingen = bestellingLogica.GetBestellingsitems(werknemer);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BouwUI();
            };
            timer.Start();
        }

        private void BarKeukenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
