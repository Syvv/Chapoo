﻿using System;
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
        System.Timers.Timer timer;
        BarKeukenHeader header;

        public BarKeukenForm(Model.WerknemerModel werknemer, DAOFactory factory)
        {
            InitializeComponent();
            this.werknemer = werknemer;
            this.factory = factory;
            maxContainerHeight = this.Height - 35; //The full height of the screen minus the height of the Controls at the top.

            if(werknemer.Functie==Functie.Bar)
            {
                header = new BarKeukenHeader(LogOut, ShowOrders, factory, false); //initialize the header
            }
            else
            {
                header = new BarKeukenHeader(LogOut, ShowOrders, factory, true); //initialize the header
            }
            
            bestellingLogica = new BestellingsItemService();
            //Get all currently open orders
            try
            {
                Bestellingen = bestellingLogica.GetBestellingsitems(werknemer, factory);
            }catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitialiseTimer();
            BuildUI();
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
                Panel ItemLijstContainer = new Panel() { Top = 60, AutoSize = true, AutoScroll = true, Width = 1600, };
                int y = 0;
                foreach (BestellingsitemModel b in Bestellingen)
                {
                    BarKeukenUIElement uiElement = new BarKeukenUIElement(b, bestellingLogica, (item) => { Bestellingen.Remove(item); BuildUI(); }, factory)
                        { Top = y};
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

        private void ShowOrders(bool showCurrentOrdersOnly)
        {
            if(showCurrentOrdersOnly)
            {
                timer.Start();
                try
                {
                    Bestellingen = bestellingLogica.GetBestellingsitems(werknemer, factory);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BuildUI();
            }
            else
            {
                timer.Stop();
                try
                {
                    Bestellingen = bestellingLogica.GetAlleBestellingenVanVandaag(werknemer, factory);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BuildUI();
            }
        }

        private void InitialiseTimer()
        {
            timer = new System.Timers.Timer { Interval = 60000 }; //1 minute
            timer.Elapsed += (s, e) => {
                try
                {
                    Bestellingen = bestellingLogica.GetBestellingsitems(werknemer, factory);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BuildUI();
            };
            timer.Start();
        }

        private void BarKeukenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
