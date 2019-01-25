using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;
using Styleguide;

namespace UI
{
    public partial class RekeningForm_Betaal : StyleGuide.BaseFormMobile
    {
        RekeningLogica rekeningLogica = new RekeningLogica();
        bool ingevuld = false;
        int tafelnummer;
        public RekeningForm_Betaal(int tafelId)
        {
            InitializeComponent();
            LadenBetaalScherm();

            LblTafelnummer.Text = tafelId.ToString();
            tafelnummer = tafelId;
        }        
        private void LadenBetaalScherm()
        {
            Rekening rekening = rekeningLogica.RekeningOpstellen();
            
            OutBedragZondFooi.Text = string.Format("€ {0:F2} ", rekening.Totaalbedrag);
            OutTotaalEind.Text = string.Format("€ {0:F2} ", rekening.Totaalbedrag);
            OutFooi.Text = "€ 0,00";
        }

        private void btnBerekenFooi_Click(object sender, EventArgs e)
        {
            FooiCheck();
        }

        private void BtnBetalingAfronden_Click(object sender, EventArgs e)
        {
            FooiCheck();
            if (FooiIngevuldCheck())
            {
                rekeningLogica.RekeningWegschrijven();
                new RekeninfForm_Bevestiging(tafelnummer).Show();
                this.Close();
            }
        }
        private void FooiCheck()
        {
            Rekening rekening = rekeningLogica.RekeningOpstellen();
            try
            {
                decimal totaal = Convert.ToDecimal(TbBedragBetaald.Text);
                if (rekeningLogica.KloptFooi(rekening, totaal))
                {
                    MessageBox.Show("bedrag is te laag");
                    return;
                }
                decimal fooi = rekeningLogica.FooiBerekenen(ref rekening, totaal);

                OutFooi.Text = string.Format("€ {0:F2} ", fooi);
                OutTotaalEind.Text = string.Format("€ {0:F2} ", rekening.Totaalbedrag);
                ingevuld = true;
            }
            catch
            {
                MessageBox.Show("Verkeerde invoer");
            }
        }
        private bool FooiIngevuldCheck()
        {
            if (ingevuld)
            {
                return true;
            }
            else
            {
                string test = TbBedragBetaald.Text;
                if (string.IsNullOrEmpty(test))
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            Afronden();
        }

        private void BtnCreditcard_Click(object sender, EventArgs e)
        {
            Afronden();
        }

        private void Afronden()
        {
            FooiCheck();
            if (FooiIngevuldCheck())
            {
                rekeningLogica.RekeningWegschrijven();
                new RekeninfForm_Bevestiging(tafelnummer).Show();
                this.Close();
            }
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
