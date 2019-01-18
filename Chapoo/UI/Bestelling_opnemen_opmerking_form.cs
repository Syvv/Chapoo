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

namespace UI
{
    public partial class Bestelling_opnemen_opmerking_form : Form
    {
        public Bestelling_opnemen_form bestelling_Opnemen_Form;
        public Bestelling_opnemen_opmerking_form(Bestelling_opnemen_form bestelling_Opnemen_Form)
        {
            InitializeComponent();
            this.bestelling_Opnemen_Form = bestelling_Opnemen_Form;
        }

        private void btnSendComment_Click(object sender, EventArgs e)
        {
            bestelling_Opnemen_Form.ChangeComment(txtComment.Text);
            bestelling_Opnemen_Form.ChangeAantal(txtAantal.Text);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Bestelling_opnemen_opmerking_form_Load(object sender, EventArgs e)
        {

        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
