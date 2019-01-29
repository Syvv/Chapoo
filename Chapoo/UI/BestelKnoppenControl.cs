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

namespace UI
{
    public partial class BestelKnoppenControl : UserControl
    {
        public BestellingModel Bestelling { get; set; }
        private BestellingService BestellingService { get; set; }
        public TafelModel Tafel { get; set; }
        int TafelId { get; set; }
        private BestellingsitemModel Bestellingsitem { get; set; }
        private List<BestelItemControl> BestelItemControls { get; set; }
        private List<BestellingsitemModel> Bestellingsitems { get; set; }
        private BestellingsItemService BestellingsItemService { get; set; }
        public BestelKnoppenControl(BestellingModel bestelling, TafelModel tafel, List<BestelItemControl> bestelItemControls)
        {
            InitializeComponent();
            this.Bestelling = bestelling;
            this.Tafel = tafel;
            this.TafelId = tafel.Id;
            MessageBox.Show(Tafel.Id.ToString());
            this.BestelItemControls = bestelItemControls;
        }
        public BestelKnoppenControl()
        {
            InitializeComponent();
        }
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            BestellingService = new BestellingService();
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
                    if (bestellingOpen)
                    {
                       Bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    else
                    {
                        //Creeër nieuw bestelling en geef de bestellingId mee van de nieuwe Bestelling
                        int bestellingId = BestellingService.InsertBestelling(Bestelling);
                        Bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    Bestellingsitems.Add(Bestellingsitem);
                }
            }

            if(Bestellingsitems.Any())
                BestellingsItemService.InsertBestellingItems(Bestellingsitems);
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {

        }
    }
}
