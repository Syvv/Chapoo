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
        List<Logica.BarKeukenUIElement> UIElements = new List<Logica.BarKeukenUIElement>();
        private User user;

        public BarKeukenForm(User user)
        {
            InitializeComponent();
            this.user = user;
            Logica.BarKeukenQueue.getBestellingen(this.user);
            BuildForm();
        }

        private void BuildForm()
        {
            Controls.Clear();
            foreach (Bestellingsitem b in Model.BestelLijst.List)
            {
                UIElements.Add(new Logica.BarKeukenUIElement(b, () => { BuildForm(); }));
            }

            //add the controls that belong to all BarKeukenUIElements so that you can actually see them
            foreach(Logica.BarKeukenUIElement ui in UIElements)
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
