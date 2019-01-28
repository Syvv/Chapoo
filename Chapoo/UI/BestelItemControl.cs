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
    public partial class BestelItemControl : UserControl
    {
        public Model.MenuItemModel MenuItem { get; set; }
        public bool Add = false;
        public BestellingOpnemenForm BestellingOpnemenForm { get; set; }
        public ItemOptiesControl ItemOpties { get; set; }
        public BestelKnoppenControl BestelKnoppen { get; set; }
        public BestellingsitemModel Bestellingsitem { get; set; }
        public DateTime TimeStamp = DateTime.Today;

        public BestelItemControl(Model.MenuItemModel item, BestellingOpnemenForm bestellingOpnemenForm, BestelKnoppenControl bestelKnoppen)
        {
            InitializeComponent();
            this.MenuItem = item;
            this.lblItem.Text = MenuItem.Naam;
            this.BackColor = Color.FromArgb(245, 239, 237);
            this.BestellingOpnemenForm = bestellingOpnemenForm;
            this.BestelKnoppen = bestelKnoppen;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            ItemOpties = new ItemOptiesControl(this, BestellingOpnemenForm);
            BestellingOpnemenForm.pnlBottom.Controls.Clear();

            if (addButton1.Text == "+")
            {
                addButton1.Text = "x";

            }
            else
            {
                addButton1.Text = "+";
            }
            if (!Add)
            {
                Add = true;                
                BestellingOpnemenForm.pnlBottom.Controls.Add(ItemOpties);
                addButton1.BackColor = Color.FromArgb(106, 57, 55);
            }
            else
            {
                Add = false;
                BestellingOpnemenForm.pnlBottom.Controls.Add(BestelKnoppen);
                addButton1.BackColor = Color.FromArgb(245, 239, 237);
                ItemOpties.Aantal = 0;
            }           
        }
        private void BestelItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 0, 0);
        }
        private void BestelItem_Load(object sender, EventArgs e)
        {

        }
    }
}
