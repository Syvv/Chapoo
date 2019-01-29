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
        RekeningService RekeningLogica { get; set; }
        private RekeningGeldOverzicht Geldoverzicht { get; set; }
        private RekeningItem Rekeningitem { get; set; }
        private RekeningModel Rekening { get; set; }
        private TafelModel Tafel { get; set; }
        private WerknemerModel Werknemer { get; set; }

        public RekeningFormOverzicht(TafelModel tafel, WerknemerModel werknemer)
        {
            InitializeComponent();
            
            this.RekeningLogica = new RekeningService();            
            this.Tafel = tafel;
            this.Werknemer = werknemer;

            WeergevenRekeningItems();
            WeergevenRekeningPrijzen();//naam aanpassen

            //this.Tafel.Bestelling.Id = 1;

            this.Rekening.Bestelling.Id = 2;

            this.btnMenuAfrekenen.Click += new EventHandler(btnMenuAfrekenen_Click);
            this.btnMenuOverzicht.Click += new EventHandler(btnMenuOverzicht_Click);
            this.btnMenuOpnemen.Click += new EventHandler(btnMenuOpnemen_Click);
        }

        private void btnMenuOpnemen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMenuOverzicht_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnMenuAfrekenen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WeergevenRekeningItems()
        {
            int bestellingId = 2;
            List<BestellingsitemModel> BestellingenLijst = RekeningLogica.BesteldeItems(bestellingId);
            int y = 40;

            foreach(BestellingsitemModel item in BestellingenLijst) //lokoatie aanpassen
            {
                this.Rekeningitem = new RekeningItem(item.Naam, item.Hoeveelheid, item.Prijs, item.Hoeveelheid * item.Prijs);
                pnlMain.Controls.Add(this.Rekeningitem);

                y += 10;//de hoogte van de RekeningItem
            }            
        }
        private void WeergevenRekeningPrijzen()  //lokatie aanpassen
        {            
            this.Geldoverzicht = new RekeningGeldOverzicht(Rekening);
            Geldoverzicht.Top = 550; //nog aanpassen
            pnlBottom.Controls.Add(this.Geldoverzicht);
        }
    }
}
