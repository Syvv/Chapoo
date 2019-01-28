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
        public MenuItemService MenuItemService = new MenuItemService();
        BestelItemControl BestelItem { get; set; }
        BestelKnoppenControl BestelKnoppen { get; set; }
        private BestellingModel Bestelling { get; set; }
        private WerknemerModel Werknemer { get; set;}
        private TafelModel Tafel { get; set; }

        public BestellingOpnemenForm()
        {
            this.Tafel = new TafelModel(1);
            this.Werknemer = new WerknemerModel(1);
            this.Bestelling = new BestellingModel(Werknemer, Tafel);
            this.BestelKnoppen = new BestelKnoppenControl(Bestelling);
            foreach (MenuItemModel menuItem in MenuItemService.GetItems())
            {
                BestelItem = new BestelItemControl(menuItem, this, BestelKnoppen);                
                pnlMain.Controls.Add(BestelItem);
            }            
            pnlBottom.Controls.Add(BestelKnoppen);
        }

        public BestellingOpnemenForm(WerknemerModel werknemer, TafelModel tafel)
        {
            this.Tafel = tafel;
            this.Werknemer = new WerknemerModel(1);
            this.Bestelling = new BestellingModel(Werknemer, Tafel);
            this.BestelKnoppen = new BestelKnoppenControl(Bestelling);
            foreach (MenuItemModel menuItem in MenuItemService.GetItems())
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
            //new TafelOverzicht(Werknemer, ).Show();
        }
    }
}
