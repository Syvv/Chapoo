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
        private BestellingsItemService bestellingsItemService { get; set; }

        DAOFactory factory;

        private List<BestelItemControl> BestelItemControls = new List<BestelItemControl>();


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
                        int bestellingId = BestellingService.InsertBestelling(Bestelling,factory);
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

        }

        private void BestelKnoppenControl_Load(object sender, EventArgs e)
        {

        }
    }
}
