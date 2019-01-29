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
        private BestellingsitemModel BestellingItemModel { get; set; }
        private List<BestelItemControl> BestelItemControls = new List<BestelItemControl>();
        //Lijst aanmaken van bestellingitems
        //Voorraad toonen

        //ik(robbin) heb dit even neergezet net als de button onderin, niet schrikken
        private DAOFactory factory;
        public BestellingOpnemenForm(WerknemerModel werknemer, TafelModel tafel, DAOFactory factory)
        {
            this.Tafel = tafel;
            this.Werknemer = werknemer;
            this.BestelKnoppen = new BestelKnoppenControl(Tafel, factory, BestelItemControls);
            this.MenuItemService = new MenuItemService();

            txtTafel.Text += " " + Tafel.Id.ToString();

            foreach(MenuItemModel menuItem in MenuItemService.GetItems(factory))
            {
                BestelItem = new BestelItemControl(menuItem, this, BestelKnoppen);
                BestelItemControls.Add(BestelItem);
                pnlMain.Controls.Add(BestelItem);
            }           

            pnlBottom.Controls.Add(BestelKnoppen);

            //Robbin heeft dit ook neergezet
            this.factory = factory;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("message");
        }
        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnTijdelijk_Click(object sender, EventArgs e)
        {
            //tijdelijke connectie naar mijn deel
            RekeningFormOverzicht form = new RekeningFormOverzicht(factory, Tafel);
            form.Show();
        }
    }
}
