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
        public BestellingService BestellingService { get; set; }
        public TafelModel Tafel { get; set; }
        private BestellingsitemModel Bestellingsitem { get; set; }
        public BestelKnoppenControl(BestellingModel bestelling, TafelModel tafel)
        {
            InitializeComponent();
            this.Bestelling = bestelling;
        }
        public BestelKnoppenControl()
        {
            InitializeComponent();
        }
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            BestellingService = new BestellingService();
            int laatsteBestellingId = BestellingService.GetLaatseBestelling(Tafel);
            bool bestellingOpen = BestellingService.CheckVoorOpenstaandeBestelling(laatsteBestellingId);
            if (bestellingOpen)
            {
                //Insert items met openstaande bestellingId (laatsteBestelling)
               
            }
            else
            {
                //BestellingService.InsertBestelling(Bestelling);
                //Creeër nieuw bestelling en geef de bestellingId mee van de nieuwe Bestelling
            }
        }
    }
}
