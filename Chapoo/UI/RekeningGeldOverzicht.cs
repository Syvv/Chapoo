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
        private int BestellingsId { get; set; }
        public RekeningGeldOverzicht(RekeningModel rekening, int BestellingsId)
        {
            InitializeComponent();
            this.Rekening = rekening;
            this.RekeningLogica = new RekeningService();
            this.BestellingsId = BestellingsId;
            PrijzenWeergeven();

            lblOpmerking.Hide();
            OutOpmerking.Hide();
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
            string opmerking = Rekening.Opmerking;
            RekeningOpmerkingForm form = new RekeningOpmerkingForm(opmerking);
            form.ShowDialog();

            this.Rekening.Opmerking = form.Opmerking;
            lblOpmerking.Show();
            OutOpmerking.Show();
            OutOpmerking.Text = Rekening.Opmerking;
        }

        private void BtnFooi_Click(object sender, EventArgs e) //deze sluiten???
        {
            new RekeningFooiForm_en_betalen(this.Rekening, BestellingsId).Show();
        }
    }
}
