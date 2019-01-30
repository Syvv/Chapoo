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
        private int BestellingsId { get; set; }

        public RekeningFormOverzicht(TafelModel tafel, WerknemerModel werknemer)
        {
            InitializeComponent();
            
            this.RekeningLogica = new RekeningService();            
            this.Tafel = tafel;
            this.Werknemer = werknemer;
            this.BestellingsId = BestellingsIdOphalen(Tafel.Id);
            
            WeergevenRekeningItems();
            WeergevenRekeningPrijzen();//naam aanpassen

            this.btnMenuAfrekenen.Click += new EventHandler(btnMenuAfrekenen_Click);
            this.btnMenuOpnemen.Click += new EventHandler(btnMenuOpnemen_Click);
        }
        public int BestellingsIdOphalen(int tafelId)
        {
            return (int) RekeningLogica.BestellingsIdOphalen(tafelId);
        }

        private void btnMenuOpnemen_Click(object sender, EventArgs e)
        {
            new BestellingOpnemenForm(Werknemer, Tafel).Show();
            this.Close();
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
            try
            {
                List<BestellingsitemModel> BestellingenLijst = RekeningLogica.BesteldeItems(BestellingsId);
                int y = 40;

                foreach(BestellingsitemModel item in BestellingenLijst) //lokoatie aanpassen
                {
                    this.Rekeningitem = new RekeningItem(item.Naam, item.Hoeveelheid, item.Prijs, item.Hoeveelheid * item.Prijs);
                    pnlMain.Controls.Add(this.Rekeningitem);

                    y += 10;//de hoogte van de RekeningItem
                }  
            }
            catch { MessageBox.Show("nog geen bestelling gedaan"); }
          
        }
        private void WeergevenRekeningPrijzen()  //lokatie aanpassen
        {            
            this.Geldoverzicht = new RekeningGeldOverzicht(Rekening, BestellingsId);
            Geldoverzicht.Top = 550; //nog aanpassen
            pnlBottom.Controls.Add(this.Geldoverzicht);
        }
    }
}
