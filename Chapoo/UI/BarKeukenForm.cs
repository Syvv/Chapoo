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
        List<BestellingsitemModel> Bestellingen = new List<BestellingsitemModel>();
        BestellingsItemService bestellingLogica;
        DAOFactory factory;
        private Model.WerknemerModel werknemer;
        delegate void CreateTimerCallback();
        private int maxContainerHeight;

        public BarKeukenForm(Model.WerknemerModel werknemer, DAOFactory factory)
        {
            InitializeComponent();
            this.werknemer = werknemer;
            this.factory = factory;
            bestellingLogica = new BestellingsItemService(werknemer, factory);
            Bestellingen = bestellingLogica.GetBestellingsitems();
            maxContainerHeight = this.Height - 35; //The full height of the screen minus the height of the Controls at the top.
            BuildUI();
            
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 60000 //1 minute
            };
            timer.Elapsed += (s, e) => {
                //BarKeukenQueue.getBestellingen(this.user);
                BuildUI();
            };
            timer.Start();
        }

        
        private void BuildUI()
        {
            if(this.InvokeRequired)//Check if we're calling from a different thread
            {
                //if so invoke the method from a delegate instead
                CreateTimerCallback cb = new CreateTimerCallback(BuildUI);
                this.Invoke(cb);
            }
            else
            {
                Controls.Clear();
                BarKeukenHeader header = new BarKeukenHeader(LogOut) { Left = 75 };
                Panel ItemLijstContainer = new Panel() { Top = 60, Left = 75, AutoSize = true, AutoScroll = true, Width = 1600, };
                int y = 0;
                foreach (BestellingsitemModel b in Bestellingen)
                {
                    BarKeukenUIElement uiElement = new BarKeukenUIElement(b, bestellingLogica, (item) => { Bestellingen.Remove(item); BuildUI(); }){ Top = y};
                    ItemLijstContainer.Controls.Add(uiElement);
                    y += uiElement.Height + 5;
                }
                Controls.Add(header);
                Controls.Add(ItemLijstContainer);
            }
            
        }

        private void LogOut()
        {
            new Login(factory).Show();
            this.Hide();
        }

        private void BarKeukenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
