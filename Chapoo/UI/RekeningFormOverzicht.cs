using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using StyleGuide;
using DataAdaptor;

namespace UI
{
    public partial class RekeningFormOverzicht : BaseFormMobile
    {
        RekeningLogica RekeningLogica { get; set; }
        private RekeningGeldOverzicht Geldoverzicht { get; set; }
        private RekeningItem Rekeningitem { get; set; }
        private Rekening Rekening { get; set; }
        private Tafel Tafel { get; set; }
        private DAOFactory factory;

        public RekeningFormOverzicht(DAOFactory factory, Tafel tafel)
        {
            InitializeComponent();
            this.factory = factory;
            
            this.RekeningLogica = new RekeningLogica(factory);
            this.Geldoverzicht = new RekeningGeldOverzicht(Rekening);
            this.Tafel = tafel;

            WeergevenRekeningItems();
        }

        private void WeergevenRekeningItems()
        {
            int bestellingId = Tafel.Bestelling.Id;
            List<Bestellingsitem> BestellingenLijst = RekeningLogica.BesteldeItems(bestellingId);
            foreach(Bestellingsitem item in BestellingenLijst)
            {
                this.Rekeningitem = new RekeningItem(item.Naam, item.Hoeveelheid, item.Prijs, item.Hoeveelheid * item.Prijs);
                Controls.Add(this.Rekeningitem);
            }
            
        }

    }
}
