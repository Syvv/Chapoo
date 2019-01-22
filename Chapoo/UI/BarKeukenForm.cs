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

namespace UI
{
    public partial class BarKeukenForm : Form
    {
        List<BarKeukenUIElement> UIElements = new List<BarKeukenUIElement>();
        private Model.User user;
        delegate void CreateTimerCallback();

        public BarKeukenForm(Model.User user)
        {
            InitializeComponent();
            this.user = user;
            BarKeukenQueue.getBestellingen(this.user);
            BuildForm();
            
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 60000 //1 minute
            };
            timer.Elapsed += (s, e) => {
                BarKeukenQueue.getBestellingen(this.user);
                BuildForm();
            };
            timer.Start();
        }

        
        private void BuildForm()
        {
            if(this.InvokeRequired)//Check if were calling from a different thread
            {
                //if so invoke the method from a delegate instead
                CreateTimerCallback cb = new CreateTimerCallback(BuildForm);
                this.Invoke(cb);
            }
            else
            {
                Controls.Clear();
                UIElements.Clear();
                int y = 0;
                foreach (Bestellingsitem b in BestelLijst.List)
                {
                    UIElements.Add(new BarKeukenUIElement(b, () => { BuildForm(); }, 10, y));
                    y += 25;
                }

                //add the controls that belong to all BarKeukenUIElements so that you can actually see them
                foreach (BarKeukenUIElement ui in UIElements)
                {
                    foreach(Control c in ui.Controls)
                    {
                        Controls.Add(c);
                    }
                }
            }
            
        }

        private void BarKeukenForm_Load(object sender, EventArgs e)
        {

        }

        private void BarKeukenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BarKeukenQueue.PreserveData();
            Application.Exit();
        }
    }
}
