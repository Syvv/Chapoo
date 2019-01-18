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
    public partial class RekeningForm_Overzicht : Style_guide.BaseFormMobile
    {
        //doorgeven van aangeklikte tafelnummer
        int tafelNummer = 1;
        RekeningLogica rekeningLogica = new RekeningLogica();

        public RekeningForm_Overzicht() : base()
        {
            InitializeComponent();
            PrijzenWeergeven();
            GridViewVuller();
        }
        private void PrijzenWeergeven()
        {
            //Rekening rekening = rekeningLogica.PrijsOptellerMakkelijk();
            Rekening rekening = rekeningLogica.RekeningOpstellen();
            //rekening.BedragZonderBtw.ToString()

            OutExclBtw.Text = string.Format("€ {0:F2} ", rekening.BedragZonderBtw);
            OutBtw6.Text = string.Format("€ {0:F2} ", rekening.Btw6);
            OutBtw21.Text = string.Format("€ {0:F2} ", rekening.Btw21);
            OutInclBtw.Text = string.Format("€ {0:F2} ", rekening.Totaalbedrag);
        }
        private void GridViewVuller() //try catch vervangen??
        {
            try
            {
                List<Model.BesteldRekening> besteld = rekeningLogica.OpvragenBesteldeItems(tafelNummer);
                GridVwOverzicht.DataSource = besteld;
            }
            catch
            {
                MessageBox.Show("geen bestellingen");
            }            
        }

        private void RekeningForm_Overzicht_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpmerking_Click(object sender, EventArgs e)
        {
            var Opmerking = new Rekening_OpmerkingForm();
            Opmerking.Show();
        }

        private void BtnDoor_Click(object sender, EventArgs e)
        {
            var Doorgaan = new RekeningForm_Betaal();
            Doorgaan.Show();
            this.Close();
        }
    }
}
