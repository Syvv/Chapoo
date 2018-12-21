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
using Styleguide;

namespace UI
{
    public partial class RekeningForm_Overzicht : Style_guide.BaseFormMobile
    {
        //doorgeven van aangeklikte tafelnummer
        int tafelNummer = 0;

        public RekeningForm_Overzicht() : base()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGritVieuw_Click(object sender, EventArgs e)
        {
            var Logic = new RekeningLogica();

        }

        private void RekeningForm_Overzicht_Load(object sender, EventArgs e)
        {

        }
    }
}
