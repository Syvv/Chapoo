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
        public string Comment { get; set; }
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
            this.Comment = txtComment.Text;
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
        }

        private void btnNul_Click(object sender, EventArgs e)
        {
            Aantal = Aantal * 10;
            txtAantal.Text = Aantal.ToString();
            BestelItemControl.addButton1.Text = Aantal.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Aantal = 0;
            BestelItemControl.addButton1.Text = "x";
            txtAantal.Text = "";
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
