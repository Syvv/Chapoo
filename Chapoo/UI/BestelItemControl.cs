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
        public bool Add = false;
        public BestellingOpnemenForm BestellingOpnemenForm { get; set; }
        public ItemOptiesControl ItemOpties { get; set; }
        public BestelKnoppenControl BestelKnoppen { get; set; }

        public MenuItemModel MenuItem { get; set; }
        public DateTime TimeStamp { get; set; }
        public string naam;
        public string Commentaar = " ";

        private int aantal;
        public int Aantal {
            get
            {
                return aantal;
            }
            set
            {
                if(value > MenuItem.Voorraad)
                {
                    aantal = 0;
                }
                else
                {
                    aantal = value;
                }
            }
        }

        public BestelItemControl(MenuItemModel item, BestellingOpnemenForm bestellingOpnemenForm, BestelKnoppenControl bestelKnoppen)
        {
            InitializeComponent();
            this.MenuItem = item;
            this.lblItem.Text = MenuItem.Naam;
            this.BackColor = Color.FromArgb(245, 239, 237);
            this.BestellingOpnemenForm = bestellingOpnemenForm;
            this.BestelKnoppen = bestelKnoppen;
            this.naam = item.Naam;
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            ItemOpties = new ItemOptiesControl(this, BestellingOpnemenForm, BestelKnoppen);
            BestellingOpnemenForm.pnlBottom.Controls.Clear();
            this.TimeStamp = DateTime.Now;

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
                BestelKnoppen.BestelItemControls.Add(this);
                this.Aantal = 1;
            }
            else
            {
                Add = false;
                BestellingOpnemenForm.pnlBottom.Controls.Add(BestelKnoppen);
                addButton1.BackColor = Color.FromArgb(245, 239, 237);
                BestelKnoppen.BestelItemControls.Remove(this);
                this.Aantal = 0;
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
