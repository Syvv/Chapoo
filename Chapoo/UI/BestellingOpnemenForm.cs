using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleGuide;
using Model;
using Logica;
using DataAdaptor;

namespace UI
{
    public partial class BestellingOpnemenForm : BaseFormMobile
    {
        private MenuItemService MenuItemService { get; }
        private BestelItemControl BestelItem { get; set; }
        private BestelKnoppenControl BestelKnoppen { get; set; }

        private WerknemerModel Werknemer { get; set;}
        private TafelModel Tafel { get; set; }

        public BestellingOpnemenForm(WerknemerModel werknemer, TafelModel tafel)
        {
            this.Tafel = tafel;
            this.Werknemer = werknemer;
            this.BestelKnoppen = new BestelKnoppenControl(Tafel,  this);
            this.MenuItemService = new MenuItemService();

            this.btnMenuAfrekenen.Click += new EventHandler(btnMenuAfrekenen_Click);
            this.btnMenuOverzicht.Click += new EventHandler(btnMenuOverzicht_Click);
            this.btnMenuOpnemen.Click += new EventHandler(btnMenuOpnemen_Click);

            txtTafel.Text += " " + Tafel.Id.ToString();

            foreach(MenuItemModel menuItem in MenuItemService.Categoriseren(Categorie.Frisdrank))
            {
                BestelItem = new BestelItemControl(menuItem, this, BestelKnoppen);
//Ook nog ff naar kijken
                if (menuItem.Voorraad == 0)
                {
                    BestelItem.addButton1.Hide();
                    BestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                pnlMain.Controls.Add(BestelItem);
            }           

            pnlBottom.Controls.Add(BestelKnoppen);
        }
        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnMenuAfrekenen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello there");
            new RekeningFormOverzicht(Tafel).Show();
            this.Close();
        }

        private void btnMenuAfrekenen_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMenuOverzicht_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuOpnemen_Click(object sender, EventArgs e)
        {

        }
    }
}
