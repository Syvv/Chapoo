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
    public partial class Rekening_OpmerkingForm : StyleGuide.BaseFormMobile
    {
        RekeningLogica rekeningLogica = new RekeningLogica();

        public Rekening_OpmerkingForm(int tafelnummer)
        {
            InitializeComponent();
            OpmerkingWeergeven();
            LblTafelnummer.Text = tafelnummer.ToString();
        }

        private void BtnOpslaan_Click(object sender, EventArgs e)
        {
            string opmerking = Tbopmerking.Text;
            
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
            string opmerking = rekeningLogica.OpmerkingWeergeven();
            Tbopmerking.Text = opmerking;
        }

        private void homeButton2_Click(object sender, EventArgs e)
        {
            new Bediening_menu_form().Show();
            this.Close();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            new Bediening_menu_form().Show();
            this.Close();
        }
    }
}
