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
        public TafelModel Tafel { get; set; }
        int TafelId { get; set; }
        private BestellingsItemService BestellingsItemService { get; set; }

        DAOFactory factory;

        private List<BestelItemControl> BestelItemControls = new List<BestelItemControl>();
        private List<BestellingsitemModel> Bestellingsitems = new List<BestellingsitemModel>();

        public BestelKnoppenControl(TafelModel tafel, DAOFactory factory, List<BestelItemControl> bestelItemControls)
        {
            InitializeComponent();
            this.Tafel = tafel;
            this.TafelId = tafel.Id;
            this.factory = factory;
            this.BestelItemControls = bestelItemControls;
        }
        public BestelKnoppenControl()
        {
            InitializeComponent();
        }
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            BestellingService = new BestellingService();
            BestellingsItemService = new BestellingsItemService();

            int laatsteBestellingId = BestellingService.GetLaatseBestelling(TafelId);
            bool bestellingOpen = BestellingService.CheckVoorOpenstaandeBestelling(laatsteBestellingId);

            foreach (BestelItemControl bestelItemControl in BestelItemControls)
            {
                int menuId = bestelItemControl.MenuItem.MenuId;
                DateTime timestamp = bestelItemControl.TimeStamp;
                int hoeveelheid = bestelItemControl.Aantal;
                string commentaar = bestelItemControl.Commentaar;

                if (bestelItemControl.Aantal > 0)
                {
                    BestellingsitemModel bestellingsitem;

                    if (bestellingOpen)
                    {
                       bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    else
                    {
                        //Creeër nieuw bestelling en geef de bestellingId mee van de nieuwe Bestelling
                        int bestellingId = BestellingService.InsertBestelling(Bestelling);
                        bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    Bestellingsitems.Add(bestellingsitem);
                }
            }

            //if(Bestellingsitems.Any())
                BestellingsItemService.InsertBestellingItems(Bestellingsitems, factory);
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {

        }
    }
}
