using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ItemOptiesControl : UserControl
    {
        public int Aantal { get; set; }
        public BestelItemControl BestelItemControl { get; set; }
        public BestellingOpnemenForm BestellingOpnemenForm { get; set; }
        public ItemOptiesControl(BestelItemControl bestelItemControl, BestellingOpnemenForm bestellingOpnemenForm)
        {
            InitializeComponent();
            this.BestelItemControl = bestelItemControl;
            this.Aantal = 0;
            this.BestellingOpnemenForm = bestellingOpnemenForm;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            this.BestelItemControl.Commentaar = txtComment.Text;
            this.BestellingOpnemenForm.pnlBottom.Controls.Clear();
            this.BestellingOpnemenForm.pnlBottom.Controls.Add(new BestelKnoppenControl());
        }

        private void bntEen_Click(object sender, EventArgs e)
        {
            if(Aantal == 0)
            {
                Aantal += 1;
            }
            else
            {
                Aantal = Aantal * 10 + 1;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnTwee_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 2;
            }
            else
            {
                Aantal = Aantal * 10 + 2;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnDrie_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 3;
            }
            else
            {
                Aantal = Aantal * 10 + 3;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnVier_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 4;
            }
            else
            {
                Aantal = Aantal * 10 + 4;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void vtnVijf_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 5;
            }
            else
            {
                Aantal = Aantal * 10 + 5;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void vtnZes_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 6;
            }
            else
            {
                Aantal = Aantal * 10 + 6;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void vtnZeven_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 7;
            }
            else
            {
                Aantal = Aantal * 10 + 7;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnAcht_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 8;
            }
            else
            {
                Aantal = Aantal * 10 + 8;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnNegen_Click(object sender, EventArgs e)
        {
            if (Aantal == 0)
            {
                Aantal += 9;
            }
            else
            {
                Aantal = Aantal * 10 + 9;
            }
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnNul_Click(object sender, EventArgs e)
        {
            Aantal = Aantal * 10;
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
            BestelItemControl.Aantal = Aantal;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Aantal = 0;
            BestelItemControl.addButton1.Text = "x";
            txtAantal.Text = "";
            BestelItemControl.Aantal = Aantal;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
