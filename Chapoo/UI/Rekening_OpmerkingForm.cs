using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Styleguide;
using Model;
using Logica;

namespace UI
{
    public partial class Rekening_OpmerkingForm : Style_guide.BaseFormMobile
    {
        public Rekening_OpmerkingForm()
        {
            InitializeComponent();
            OpmerkingWeergeven();
        }

        private void BtnOpslaan_Click(object sender, EventArgs e)
        {
            string opmerking = Tbopmerking.Text;
            var rekeningLogica = new RekeningLogica();

            rekeningLogica.OpmerkingToevoegen(opmerking);

            MessageBox.Show("opmerking opgeslagen");
            this.Close();
        }

        private void BtnAnuleren_Click(object sender, EventArgs e)
        {
            DialogResult resultaat = MessageBox.Show("weet u zeker dat u wilt anuleren", "Anuleren", MessageBoxButtons.YesNo);
            if (resultaat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void OpmerkingWeergeven()
        {
            var logica = new RekeningLogica();

            Rekening rekening = logica.RekeningOpstellen();
            Tbopmerking.Text = rekening.Opmerking;

            string opmerking = logica.OpmerkingWeergeven();
            MessageBox.Show(opmerking);
        }
    }
}
