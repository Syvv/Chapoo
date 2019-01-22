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

            //ListViewAanmaken(listView);
            //ListViewVuller(listView);

            LblOpmerking.Hide();
            OutOpmerking.Hide();

            listView.Hide();
            GridViewVuller();
        }
        private void TafelNummerToevoegen()
        {
            LblTafelnummer.Text = tafelNummer.ToString();
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
                List<RekeningOverzicht> besteld = rekeningLogica.OverzichtBestellingen(tafelNummer);                             

                GridVwOverzicht.DataSource = besteld;
                GridVwOverzicht.ReadOnly = true;
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

        private void ListViewAanmaken(ListView listView)
        {
            listView = new ListView();

            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Scrollable = true;
            listView.GridLines = true;

            listView.Columns.Add("item");
            listView.Columns.Add("aantal", -2, HorizontalAlignment.Left);
            listView.Columns.Add("prijs p/s", -2, HorizontalAlignment.Left);
            listView.Columns.Add("tot. prijs", -2, HorizontalAlignment.Left);

            listView.Name = "listView";

            listView.Columns[0].Width = 200;
            listView.Columns[1].Width = 20;
            listView.Columns[2].Width = 20;
            listView.Columns[3].Width = 20;

            listView.Height = 100;            
        }
        private void ListViewVuller(ListView listView)
        {
            List<BesteldRekening> besteld = rekeningLogica.OpvragenBesteldeItems(tafelNummer);
                       
            foreach( BesteldRekening b in besteld)
            {
                double totaalPrijs = b.Prijs * b.Hoeveelheid;
                string[] items = new string[4];

                ListViewItem item;

                items[0] = b.MenuItem;
                items[1] = b.Hoeveelheid.ToString();
                items[2] = b.Prijs.ToString();
                items[3] = totaalPrijs.ToString();

                item = new ListViewItem(items[0], items[1]);
                listView.Items.Add(item);
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
