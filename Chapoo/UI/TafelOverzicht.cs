using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using StyleGuide;
using DataAdaptor;

namespace UI
{
    public partial class TafelOverzicht : Form
    {
        //namen op de tafels, nummers ipv. namen
        //kleuren
        //refresher voor de kleuren, vrij, bezet, bestelling klaar

        public WerknemerModel HuidigeWerknemer { get; set; }        
        private DAOFactory factory;
        public TafelService TafelLogica;

        public TafelOverzicht(WerknemerModel werknemer)
        {
            InitializeComponent();
            this.HuidigeWerknemer = werknemer;
            titel.Text = "TafelOverzicht";
            TafelLogica = new TafelService();
        }
        private void uitlogButton1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
        private void OpenenBestellingForm(int tafelNummer)
        {
            TafelModel tafel = TafelLogica.TafelVuller(tafelNummer);
            new BestellingOpnemenForm(HuidigeWerknemer, tafel).Show();
            this.Close();
        }
        private void tafelButton1_Click(object sender, EventArgs e)
        {
            int tafelNummer = 1;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton2_Click_1(object sender, EventArgs e)
        {
            int tafelNummer = 2;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton3_Click(object sender, EventArgs e)
        {
            int tafelNummer = 3;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton4_Click(object sender, EventArgs e)
        {
            int tafelNummer = 4;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton5_Click(object sender, EventArgs e)
        {
            int tafelNummer = 5;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton6_Click(object sender, EventArgs e)
        {
            int tafelNummer = 6;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton7_Click(object sender, EventArgs e)
        {
            int tafelNummer = 7;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton8_Click(object sender, EventArgs e)
        {
            int tafelNummer = 8;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton9_Click(object sender, EventArgs e)
        {
            int tafelNummer = 9;
            OpenenBestellingForm(tafelNummer);
        }

        private void tafelButton10_Click(object sender, EventArgs e)
        {
            int tafelNummer = 10;
            OpenenBestellingForm(tafelNummer);
        }

    }
}
