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
        List<Bestellingsitem> Bestellingen = new List<Bestellingsitem>();
        BestellingsItemLogica bestellingLogica;
        DAOFactory factory;
        private Model.Werknemer werknemer;
        delegate void CreateTimerCallback();

        public BarKeukenForm(Model.Werknemer werknemer, DAOFactory factory)
        {
            InitializeComponent();
            this.werknemer = werknemer;
            this.factory = factory;
            bestellingLogica = new BestellingsItemLogica(werknemer, factory);
            Bestellingen = bestellingLogica.GetBestellingsitems();
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
                int y = 30;
                foreach (Bestellingsitem b in Bestellingen)
                {
                    BarKeukenUIElement uiElement = new BarKeukenUIElement(b);
                    uiElement.Top = y;
                    Controls.Add(uiElement);
                    y += 50;
                }
                //TODO: move this Control creation to another place
                Controls.Add(new Label { Text = "Commentaar", Top = 0, Left = 840, Font = new System.Drawing.Font("Arial", 16), Height = 30, Width = 200 });
                Button logoutbtn = new Button { Text = "Log uit!", Top = 0, Left = 0, Font = new System.Drawing.Font("Arial", 10), Height = 25, Width = 100 };
                logoutbtn.Click += (s, e) =>
                {
                    new Login().Show();
                    this.Hide();
                };
                Controls.Add(logoutbtn);
            }
            
        }

        private void BarKeukenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
