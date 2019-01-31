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
        private BestelKnoppenControl BestelKnoppen { get; set; }

        public ItemOptiesControl(BestelItemControl bestelItemControl, BestellingOpnemenForm bestellingOpnemenForm, BestelKnoppenControl bestelKnoppen)
        {
            InitializeComponent();
            this.BestelItemControl = bestelItemControl;
            this.Aantal = bestelItemControl.Aantal;
            this.BestellingOpnemenForm = bestellingOpnemenForm;
            this.BestelKnoppen = bestelKnoppen;
            txtComment.Text = BestelItemControl.Commentaar;
            txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlBottom.Controls.Clear();
            this.BestellingOpnemenForm.pnlBottom.Controls.Add(BestelKnoppen);
        }

        private void bntEen_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 1;
            }
            else
            {
                aantal = aantal * 10 + 1;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();

            BestelItemControl.Aantal = aantal;
        }

        private void btnTwee_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 2;
            }
            else
            {
                aantal = aantal * 10 + 2;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void btnDrie_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 3;
            }
            else
            {
                aantal = aantal * 10 + 3;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void btnVier_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 4;
            }
            else
            {
                aantal = aantal * 10 + 4;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void vtnVijf_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 5;
            }
            else
            {
                aantal = aantal * 10 + 5;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void vtnZes_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 6;
            }
            else
            {
                aantal = aantal * 10 + 6;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void vtnZeven_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 7;
            }
            else
            {
                aantal = aantal * 10 + 7;
            }
            BestelItemControl.Aantal = aantal;
        }

        private void btnAcht_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 8;
            }
            else
            {
                aantal = aantal * 10 + 8;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void btnNegen_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            if (aantal == 0)
            {
                aantal += 9;
            }
            else
            {
                aantal = aantal * 10 + 9;
            }
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void btnNul_Click(object sender, EventArgs e)
        {
            int aantal = BestelItemControl.Aantal;

            aantal = aantal * 10;
            BestelItemControl.addButton1.Text = aantal.ToString();
            BestelItemControl.Aantal = aantal;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Aantal = 0;
            BestelItemControl.addButton1.Text = "x";
            BestelItemControl.Aantal = Aantal;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            this.BestelItemControl.Commentaar = txtComment.Text;

            if (string.IsNullOrEmpty(BestelItemControl.Commentaar))
            {
                BestelItemControl.commentIcon.Hide();
            }
            else
            {
                BestelItemControl.commentIcon.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            BestellingOpnemenForm.pnlBottom.Controls.Clear();
            BestellingOpnemenForm.pnlBottom.Controls.Add(BestelKnoppen);
        }
    }
}
