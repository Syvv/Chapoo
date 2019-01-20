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

namespace UI
{
    public partial class Bestelling_overzicht_form : Style_guide.BaseFormMobile
    {
        Fill_orderview_list_logica orderView = new Fill_orderview_list_logica();
        public Bestelling_overzicht_form()
        {
            InitializeComponent();
            orderView.ListViewStyle(listView1);
            orderView.FillKlaarList(listView1);
        }
        
        private void Bestelling_overzicht_form_Load(object sender, EventArgs e)
        {

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillKlaarList(listView1);
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillBarList(listView1);
        }

        private void btnKeuken_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillKeukenList(listView1);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }
    }
}
