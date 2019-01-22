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
    public partial class RekeningForm_Betaal : Style_guide.BaseFormMobile
    {
        RekeningLogica rekeningLogica = new RekeningLogica();
        bool ingevuld = false;
        public RekeningForm_Betaal()
        {
            InitializeComponent();
            LadenBetaalScherm();
        }
        private void LadenBetaalScherm()
        {
            Rekening rekening = rekeningLogica.RekeningOpstellen();

            //double test = (double)Math.Round(rekening.Totaalbedrag);
            //double test2 = rekening.Totaalbedrag;

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
                MessageBox.Show("betaling is gelukt, de rest volgt nog");
            }
        }
        private void FooiCheck()
        {
            Rekening rekening = rekeningLogica.RekeningOpstellen();
            try
            {
                double totaal = Convert.ToDouble(TbBedragBetaald.Text);
                if (rekeningLogica.KloptFooi(rekening, totaal))
                {
                    MessageBox.Show("bedrag is te laag");
                    return;
                }
                double fooi = rekeningLogica.FooiBerekenen(ref rekening, totaal);

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
    }
}
