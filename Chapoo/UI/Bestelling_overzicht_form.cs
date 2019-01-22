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
        public Orderview_logica orderview = new Orderview_logica();
        public Bestelling_bevestiging_form bevestiging = new Bestelling_bevestiging_form();
        private bool bar = false;

        Fill_orderview_list_logica orderView = new Fill_orderview_list_logica();
        public Bestelling_overzicht_form()
        {
            InitializeComponent();
            orderView.ListViewStyle(listView1);
            orderView.FillKlaarList(listView1);
            btnChange.Hide();
            btnDeleteAll.Hide();
            btnDelete.Hide();
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
            btnChange.Hide();
            btnDeleteAll.Hide();
            btnDelete.Hide();
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillBarList(listView1);
            btnChange.Show();
            btnDeleteAll.Show();
            btnDelete.Show();
            bar = true;
        }

        private void btnKeuken_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillKeukenList(listView1);
            btnChange.Show();
            btnDeleteAll.Show();
            btnDelete.Show();
            bar = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string aantal = listView1.SelectedItems[0].SubItems[1].Text;
            string comment = listView1.SelectedItems[0].SubItems[2].Text;
            new Bestelling_overzicht_aanpassen_form(comment, aantal).Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bevestiging.Show();
            bevestiging.FormClosed += new FormClosedEventHandler(bevestiging_FormClosed);
        }

        private void bevestiging_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bevestiging.confirmatie == true)
            {
                MessageBox.Show("werkt");
                int id = (int)listView1.SelectedItems[0].Tag;
                orderview.DeleteItem(bevestiging.confirmatie, id, bar);
            }
            this.Update();
        }
    }
}
