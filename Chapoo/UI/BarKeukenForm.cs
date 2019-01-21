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

namespace UI
{
    public partial class BarKeukenForm : Form
    {
        List<BarKeukenUIElement> UIElements = new List<BarKeukenUIElement>();
        private User user;

        public BarKeukenForm(User user)
        {
            InitializeComponent();
            this.user = user;
            BarKeukenQueue.getBestellingen(this.user);
            BuildForm();
        }

        private void BuildForm()
        {
            Controls.Clear();
            UIElements.Clear();
            int y = 0;
            foreach (Bestellingsitem b in BestelLijst.List)
            {
                UIElements.Add(new BarKeukenUIElement(b, () => { BuildForm(); }, 10, y) );
                y += 25;
            }

            //add the controls that belong to all BarKeukenUIElements so that you can actually see them
            foreach(BarKeukenUIElement ui in UIElements)
            {
                foreach(Control c in ui.Controls)
                {
                    Controls.Add(c);
                }
            }
        }

        private void BarKeukenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
