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

            TafelNummerToevoegen();
            PrijzenWeergeven();

            ListViewAanmaken();
            ListViewVuller();

            LblOpmerking.Hide();
            OutOpmerking.Hide();

            GridVwOverzicht.Hide();
            //GridViewVuller();
        }
        private void TafelNummerToevoegen()
        {
            rekeningLogica.TafelNummer(tafelNummer);
        }
        private void PrijzenWeergeven()
        {
            Rekening rekening = rekeningLogica.RekeningOpstellen();

            OutExclBtw.Text = string.Format("€ {0:F2} ", rekening.BedragZonderBtw);
            OutBtw6.Text = string.Format("€ {0:F2} ", rekening.Btw9);
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

            OpmerkingWeergeven();
        }

        private void BtnDoor_Click(object sender, EventArgs e)
        {
            var Doorgaan = new RekeningForm_Betaal();
            Doorgaan.Show();
            this.Close();
        }

        private void ListViewAanmaken()
        {
            listView.Items.Clear();

            listView = new ListView();
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Scrollable = true;
            listView.GridLines = true;

            listView.Columns.Add("item", -2, HorizontalAlignment.Left);
            listView.Columns.Add("aantal", -2, HorizontalAlignment.Left);
            listView.Columns.Add("prijs p/s", -2, HorizontalAlignment.Left);
            listView.Columns.Add("tot. prijs", -2, HorizontalAlignment.Left);

            listView.Name = "listView";

            listView.Columns[0].Width = 100;
            listView.Columns[1].Width = 20;
            listView.Columns[2].Width = 20;
            listView.Columns[3].Width = 20;

            listView.Height = 325;
        }
        private void ListViewVuller()
        {
            List<BesteldRekening> besteld = rekeningLogica.OpvragenBesteldeItems(tafelNummer);

            for (int i = 0; i < besteld.Count; i++)
            {
                double totaalPrijs = besteld[i].Prijs * besteld[i].Hoeveelheid;
                ListViewItem lvItem = new ListViewItem(new[] { besteld[i].MenuItem, besteld[i].Hoeveelheid.ToString(), besteld[i].Prijs.ToString(), totaalPrijs.ToString() });
                //lvItem.Tag =
                listView.Items.Add(lvItem);
            }
        }
        private void OpmerkingWeergeven()
        {
            LblOpmerking.Show();
            OutOpmerking.Show();

            Rekening rekening = rekeningLogica.RekeningOpstellen();

            OutOpmerking.Text = rekening.Opmerking;
        }
    }
}
