using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;
using DataAdaptor;

namespace UI
{
    public partial class FooiToevoegen : UserControl
    {
        private RekeningModel Rekening;
        private RekeningService RekeningLogica;
        private bool IsGoedGekeurd = false; 
        private int BestellingsId { get; set; }
        private Form form;
        private WerknemerModel Werknemer { get; set; }

        public double Fooi { get; set; }

        public FooiToevoegen(RekeningModel rekening, int BestellingsId, Form form, WerknemerModel werknemer)
        {
            InitializeComponent();
            this.Rekening = rekening;
            this.RekeningLogica = new RekeningService();
            this.BestellingsId = BestellingsId;
            this.form = form;

            this.Werknemer = werknemer;
            BeginPrijzenWeeergeven();

            lblOptieKeuze.Text = "Fooi zit in het totaalbedrag";
            LblOption.Text = "Totaalbedrag";
        }

        private void RadioBtnFooiInTotaal_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnFooiInTotaal.Checked)
            {
                lblOptieKeuze.Text = "Fooi zit in het totaalbedrag";
                LblOption.Text = "Totaalbedrag";
                LblFooi.Show();
                OutFooi.Show();
            }
        }

        private void RadioBtnFooiLos_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnFooiLos.Checked)
            {
                lblOptieKeuze.Text = "Fooi los toevoegen";
                LblOption.Text = "Fooi:";

                LblFooi.Hide();
                OutFooi.Hide();
            }
        }
        private void BeginPrijzenWeeergeven()
        {
            OutBedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
            OutTotaalbedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
            OutFooi.Text = string.Format("€ 0,00 ");
        }

        private void FooiCheck()
        {
            try
            {
                double ingevuld = Convert.ToDouble(TbInvullen.Text);
                if (RadioBtnFooiInTotaal.Checked)
                {
                    if (TbInvullen.Text.Contains(','))
                    {
                        //MessageBox.Show("Er zit een komma in, inplaats van een punt");
                        string fooi = TbInvullen.Text;
                        fooi = fooi.Replace(',', '.');
                        ingevuld = Convert.ToDouble(fooi);
                    }
                    //else
                    {
                        if (RekeningLogica.FooiControlleren(Rekening, ingevuld))
                        {
                            MessageBox.Show("bedrag is te laag");
                            return;
                        }
                        RekeningLogica.FooiToevoegenInBedrag(ref Rekening, ingevuld);

                        OutFooi.Text = string.Format("€ {0:F2} ", Rekening.Fooi);
                        OutTotaalbedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
                    }
                    
                }
                if (RadioBtnFooiLos.Checked)
                {
                    if (TbInvullen.Text.Contains(','))
                    {
                        //MessageBox.Show("Er zit een komma in, inplaats van een punt");
                        string fooi = TbInvullen.Text;
                        fooi = fooi.Replace(',', '.');
                        ingevuld = Convert.ToDouble(fooi);
                    }
                    RekeningLogica.FooiLosToevoegen(ref Rekening, ingevuld);
                    OutTotaalbedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
                }
                IsGoedGekeurd = true;
            }
            catch
            {
                MessageBox.Show("Verkeerde invoer");
            }
        }
        private bool FooiIngevuldCheck()
        {
            if (IsGoedGekeurd)
            {
                return true;
            }
            else
            {
                string test = TbInvullen.Text;
                if (string.IsNullOrEmpty(test))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnPin_Click(object sender, EventArgs e)
        {
            FooiCheck();
            BetalingAfronden(BetaalMethode.pin);
            //form.Close();
        }

        private void BtnContant_Click(object sender, EventArgs e)
        {
            FooiCheck();
            BetalingAfronden(BetaalMethode.cash);
            //form.Close();
        }

        private void BtnCreditcard_Click(object sender, EventArgs e)
        {
            FooiCheck();
            BetalingAfronden(BetaalMethode.creditcard);
            //form.Close();
        }

        private void BetalingAfronden(BetaalMethode methode)
        {
            Rekening.BetaalMethode = methode;

            
            if (FooiIngevuldCheck())
            {
                RekeningLogica.RekeningBetaling(Rekening, BestellingsId);
                MessageBox.Show("bestelling is gelukt");

                new TafelOverzicht(Werknemer).Show();
                form.Close();
            }
        }
    }
}
