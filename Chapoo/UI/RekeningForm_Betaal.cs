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
        public RekeningForm_Betaal()
        {
            InitializeComponent();
            LadenBetaalScherm();
        }
        private void LadenBetaalScherm()
        {
            Rekening rekening = rekeningLogica.RekeningOpstellen();

            double test = (double)Math.Round(rekening.Totaalbedrag);
            double test2 = rekening.Totaalbedrag;

            OutBedragZondFooi.Text = Math.Round(test2, 2).ToString();
            OutTotaalEind.Text = rekening.Totaalbedrag.ToString();
            OutFooi.Text = "€ 00,00";
        }

        private void btnBerekenFooi_Click(object sender, EventArgs e)
        {
            try
            {
                double Totaal = Convert.ToDouble(TbBedragBetaald.Text);
            }
            catch
            {
                MessageBox.Show("Verkeerde invoer");
            }
            
        }
    }
}
