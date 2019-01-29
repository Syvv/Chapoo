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
using Logica;
using DataAdaptor;

namespace UI
{
    public partial class BestelKnoppenControl : UserControl
    {
        public BestellingModel Bestelling { get; set; }
        private BestellingService BestellingService { get; set; }
        private MenuItemService MenuItemService { get; set; }
        public TafelModel Tafel { get; set; }
        int TafelId { get; set; }
        private BestellingsItemService bestellingsItemService { get; set; }
        private BestellingOpnemenForm BestellingOpnemenForm { get; set; }

        TimeSpan start = new TimeSpan(10, 0, 0);
        TimeSpan end = new TimeSpan(17, 0, 0);
        TimeSpan now = DateTime.Now.TimeOfDay;

        DAOFactory factory;

        public List<BestelItemControl> BestelItemControls = new List<BestelItemControl>();


        public BestelKnoppenControl(TafelModel tafel, DAOFactory factory, List<BestelItemControl> bestelItemControls, BestellingOpnemenForm bestellingOpnemenForm)
        {
            InitializeComponent();
            this.Tafel = tafel;
            this.TafelId = tafel.Id;
            this.factory = factory;
            this.BestelItemControls = bestelItemControls;
            this.BestellingOpnemenForm = bestellingOpnemenForm;
            MenuItemService = new MenuItemService();
        }
        public BestelKnoppenControl()
        {
            InitializeComponent();
        }
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            BestellingService = new BestellingService();
            bestellingsItemService = new BestellingsItemService();

            int laatsteBestellingId = BestellingService.GetLaatseBestelling(TafelId, factory);
            bool bestellingOpen = BestellingService.CheckVoorOpenstaandeBestelling(laatsteBestellingId, factory);

            List<BestellingsitemModel> bestellingsItems = new List<BestellingsitemModel>();

            foreach (BestelItemControl bestelItemControl in BestelItemControls)
            {
                int menuId = bestelItemControl.MenuItem.MenuId;
                DateTime timestamp = bestelItemControl.TimeStamp;
                int hoeveelheid = bestelItemControl.Aantal;
                string commentaar = bestelItemControl.Commentaar;

                
                if (hoeveelheid > 0)
                {
                    BestellingsitemModel bestellingsitem;

                    if (bestellingOpen)
                    {
                       bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    else
                    {
                        //Creeër nieuw bestelling en geef de bestellingId mee van de nieuwe Bestelling
                        int bestellingId = BestellingService.InsertBestelling(Bestelling, factory);
                        bestellingsitem = new BestellingsitemModel(menuId, bestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    bestellingsItems.Add(bestellingsitem);
                }
            }

            if (bestellingsItems.Any())
            {
               bool exeception = bestellingsItemService.InsertBestellingItems(bestellingsItems, factory);
               MessageBox.Show(exeception.ToString());
            }
             
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {

        }

        private void btnFris_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            this.MenuItemService.Categoriseren(Categorie.Frisdrank);
        }

        private void btnBier_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();

            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.Bier);

            foreach(MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnWijn_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.Wijn);

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnSterk_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            this.MenuItemService.Categoriseren(Categorie.SterkeDrank);
        }

        private void btnWarm_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            this.MenuItemService.Categoriseren(Categorie.KoffieThee);
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();

            if ((now > start) && (now < end))
            {
                this.MenuItemService.Categoriseren(Categorie.LunchNagerecht);
            }
            else
            {
                this.MenuItemService.Categoriseren(Categorie.DinerNagerecht);
            }            
        }

        private void btnVoor_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();

            if ((now > start) && (now < end))
            {
                this.MenuItemService.Categoriseren(Categorie.LunchVoorgerecht);
            }
            else
            {
                this.MenuItemService.Categoriseren(Categorie.DinerVoorgerecht);
            }
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();

            if ((now > start) && (now < end))
            {
                this.MenuItemService.Categoriseren(Categorie.LunchHoofdgerecht);
            }
            else
            {
                this.MenuItemService.Categoriseren(Categorie.DinerHoofdgerecht);
            }
        }

        private void btnTussen_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            this.MenuItemService.Categoriseren(Categorie.DinerTussengerecht);
        }
    }
}
