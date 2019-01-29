using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class RekeningOpmerkingForm : Form
    {
        private string Opmerking { get; set; }
        public RekeningOpmerkingForm(ref string opmerking)
        {
            InitializeComponent();
            this.Opmerking = opmerking;

            TbOpmerking.Text = opmerking;
            opmerking = this.Opmerking;
        }

        private void BtnOpslaan_Click(object sender, EventArgs e)
        {
            string opmerking = TbOpmerking.Text;

            this.Opmerking = opmerking;

            MessageBox.Show("opmerking opgeslagen");
            this.Close();
        }

        private void BtnAnuleren_Click(object sender, EventArgs e)
        {
            DialogResult resultaat = MessageBox.Show("weet u zeker dat u wilt anuleren", "Anuleren", MessageBoxButtons.YesNo);
            if (resultaat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
