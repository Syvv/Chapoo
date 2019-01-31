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

        public WerknemerModel Werknemer { get; set;}
        public TafelModel Tafel { get; set; }

        public BestellingOpnemenForm(WerknemerModel werknemer, TafelModel tafel)
        {
            this.Tafel = tafel;
            this.Werknemer = werknemer;
            this.BestelKnoppen = new BestelKnoppenControl(this);
            this.MenuItemService = new MenuItemService();

            this.btnMenuOpnemen.BackColor = Color.FromArgb(157, 199, 200);

            this.btnMenuAfrekenen.Click += new EventHandler(btnMenuAfrekenen_Click);
            this.backButton1.Click += new EventHandler(backButton1_Click_1);
            this.uitlogButton1.Click += new EventHandler(uitlogButton1_Click);

            txtTafel.Text += " " + Tafel.Id.ToString();

            foreach(MenuItemModel menuItem in MenuItemService.Categoriseren(Categorie.Frisdrank))
            {
                BestelItem = new BestelItemControl(menuItem, this, BestelKnoppen);

                if (menuItem.Voorraad == 0)
                {
                    BestelItem.addButton1.Hide();
                    BestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                pnlMain.Controls.Add(BestelItem);
            }           

            pnlBottom.Controls.Add(BestelKnoppen);
        }

        private void btnMenuAfrekenen_Click(object sender, EventArgs e)
        {
            try
            {
                new RekeningFormOverzicht(Tafel, Werknemer).Show();
                this.Close();
            }
            catch { MessageBox.Show("1. geen tafelbestelling"); }
            
        }

        private void backButton1_Click_1(object sender, EventArgs e)
        {
            new TafelOverzicht(Werknemer).Show();
            this.Close();
        }

        private void uitlogButton1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
