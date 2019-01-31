using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class VoorraadMelding : UserControl
    {
        BestellingOpnemenForm BestellingOpnemenForm { get; set; }
        ItemOptiesControl ItemOptiesControl { get; set; }
        public VoorraadMelding(BestellingOpnemenForm bestellingOpnemenForm, MenuItemModel menuItem, ItemOptiesControl itemOpties)
        {
            InitializeComponent();
            this.BestellingOpnemenForm = bestellingOpnemenForm;
            this.ItemOptiesControl = itemOpties;
            this.BestellingOpnemenForm.pnlBottom.Controls.Clear();
            lblVoorraad.Text = "De voorraad is: " + menuItem.Voorraad;
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlBottom.Controls.Clear();
            this.BestellingOpnemenForm.pnlBottom.Controls.Add(ItemOptiesControl);
        }

    }
}
