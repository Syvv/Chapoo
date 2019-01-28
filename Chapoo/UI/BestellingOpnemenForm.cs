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


namespace UI
{
    public partial class BestellingOpnemenForm : BaseFormMobile
    {
        private MenuItemService MenuItemService { get; }
        private BestelItemControl BestelItem { get; set; }
        private BestelKnoppenControl BestelKnoppen { get; set; }
        //Hoort bestelling hier?
        private BestellingModel Bestelling { get; set; }
        private WerknemerModel Werknemer { get; set;}
        private TafelModel Tafel { get; set; }
        private BestellingsitemModel BestellingItemModel { get; set; }
        //Lijst aanmaken van bestellingitems
        //Voorraad toonen


        public BestellingOpnemenForm(WerknemerModel werknemer, TafelModel tafel)
        {
            this.Tafel = tafel;
            this.Werknemer = werknemer;
            this.Bestelling = new BestellingModel(Werknemer, Tafel);
            this.BestelKnoppen = new BestelKnoppenControl(Bestelling, Tafel);
            this.MenuItemService = new MenuItemService();

            txtTafel.Text += " " + Tafel.Id.ToString();

            foreach(MenuItemModel menuItem in MenuItemService.GetItems())
            {
                BestelItem = new BestelItemControl(menuItem, this, BestelKnoppen);
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
    }
}
