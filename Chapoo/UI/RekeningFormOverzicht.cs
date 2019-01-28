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
        private DAOFactory factory;

        public RekeningFormOverzicht(DAOFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            
            this.RekeningLogica = new RekeningLogica(factory);
            this.Geldoverzicht = new RekeningGeldOverzicht(Rekening);
            this.Rekeningitem = new RekeningItem("dit komt later", 5, 5,5);
        }

        private void WeergevenRekeningItems()
        {
            int bestellingId = 5;
            List<Bestellingsitem> x = RekeningLogica.BesteldeItems(bestellingId);
            foreach(Bestellingsitem BestellingsItem in x)
            {

            }
        }

    }
}
