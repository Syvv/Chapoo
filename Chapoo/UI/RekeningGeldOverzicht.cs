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
    public partial class RekeningGeldOverzicht : UserControl
    {
        private RekeningModel Rekening { get; set; }
        private RekeningService RekeningLogica;
        private WerknemerModel Werknemer { get; set; }
        private int BestellingsId { get; set; }
        private RekeningFormOverzicht Form { get; set; }

        private string opmerking = "x";
        public RekeningGeldOverzicht(RekeningModel rekening, int BestellingsId, WerknemerModel werknemer, RekeningFormOverzicht form)
        {
            InitializeComponent();
            this.Rekening = rekening;
            this.RekeningLogica = new RekeningService();
            this.BestellingsId = BestellingsId;
            this.Form = form;

            this.Werknemer = werknemer;
            PrijzenWeergeven();

            lblOpmerking.Hide();
            OutOpmerking.Hide();

            Rekening.Opmerking = " ";
        }
        private void PrijzenWeergeven()
        {
            this.Rekening = RekeningLogica.RekeningOpstellen(BestellingsId);
            OutTotaalBedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
            OutBtw21.Text = string.Format("€ {0:F2} ", Rekening.Btw21);
            OutBtw6.Text = string.Format("€ {0:F2}", Rekening.Btw6);
            OutFooi.Text = string.Format("€ {0:F2}", Rekening.Fooi);
        }

        private void BtnOpmerking_Click(object sender, EventArgs e) //kijken of lukt
        {
            this.opmerking = Rekening.Opmerking;
            RekeningOpmerkingForm form = new RekeningOpmerkingForm(opmerking);
            form.ShowDialog();
            this.opmerking = form.Opmerking;
            Rekening.Opmerking = this.opmerking;

            lblOpmerking.Show();
            OutOpmerking.Show();
            OutOpmerking.Text = Rekening.Opmerking;
        }

        private void BtnFooi_Click(object sender, EventArgs e) //deze sluiten???
        {            
            new RekeningFooiForm_en_betalen(this.Rekening, BestellingsId, Werknemer).Show();
            //this.Hide();
            Form.Close();
        }

        private void BtnPin_Click(object sender, EventArgs e)
        {
            //FooiCheck();
            BetalingAfronden(BetaalMethode.pin);
            //form.Close();
        }

        private void BtnContant_Click(object sender, EventArgs e)
        {
            //FooiCheck();
            BetalingAfronden(BetaalMethode.cash);
            //form.Close();
        }

        private void BtnCreditcard_Click(object sender, EventArgs e)
        {
            //FooiCheck();
            BetalingAfronden(BetaalMethode.creditcard);
            //form.Close();
        }
        private void BetalingAfronden(BetaalMethode methode)
        {
            Rekening.BetaalMethode = methode;

            //if (FooiIngevuldCheck())
            {
                RekeningLogica.RekeningBetaling(Rekening, BestellingsId);
                MessageBox.Show("bestelling is gelukt");
            }
            new TafelOverzicht(Werknemer).Show();
            this.Hide();
        }
    }
}
