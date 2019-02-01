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

            //try
            {
                this.BestellingsId = BestellingsIdOphalen(Tafel.Id);
                WeergevenRekeningItems();
                WeergevenRekeningPrijzen();//naam aanpassen
            }
            //catch
            {
                //MessageBox.Show("Er is nog geen bestelling gedaan.");
            }  
            this.btnMenuAfrekenen.Click += new EventHandler(btnMenuAfrekenen_Click);
            this.btnMenuOpnemen.Click += new EventHandler(btnMenuOpnemen_Click);
            this.btnMenuAfrekenen.BackColor = Color.FromArgb(157, 199, 200);
            txtTafel.Text = tafel.Id.ToString() ;
        }
        public int BestellingsIdOphalen(int tafelId)
        {            
            return (int)RekeningLogica.BestellingsIdOphalen(tafelId);            
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
            //throw new NotImplementedException();
        }

        private void WeergevenRekeningItems()
        {
            try
            {
                List<BestellingsitemModel> BestellingenLijst = RekeningLogica.BesteldeItems(BestellingsId);
                int y = 40;

                RekeningsItemAanhef x = new RekeningsItemAanhef();
                pnlMain.Controls.Add(x);
                foreach(BestellingsitemModel item in BestellingenLijst)
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
            this.Geldoverzicht = new RekeningGeldOverzicht(Rekening, BestellingsId, Werknemer, this);
            Geldoverzicht.Top = 550; //nog aanpassen
            pnlBottom.Controls.Add(this.Geldoverzicht);
        }

        private void uitlogButton1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void txtTafel_Click(object sender, EventArgs e)
        {

        }
    }
}
