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
        public BestelOverzichtService bestelOverzichtService = new BestelOverzichtService();
        public Bestelling_bevestiging_form bevestiging;
        public Bestelling_overzicht_aanpassen_form aanpassen;
        public bool bar = false;

        VulBestelOverzichtService orderView = new VulBestelOverzichtService();
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
            aanpassen = new Bestelling_overzicht_aanpassen_form(comment, aantal);
            aanpassen.Show();
            aanpassen.FormClosed += new FormClosedEventHandler(aanpassen_FormClosed);

        }

        private void aanpassen_FormClosed(object sender, FormClosedEventArgs e)
        {
            int id = (int)listView1.SelectedItems[0].Tag;
            if(aanpassen.confirmatie == true)
            {
                bestelOverzichtService.ChangeItem(bar, id, aanpassen.returnComment, int.Parse(aanpassen.returnAantal));

                foreach (ListViewItem item in listView1.Items)
                {
                    listView1.Items.Remove(item);
                }

                if (bar == true)
                {
                    orderView.FillBarList(listView1);
                }
                else
                {
                    orderView.FillKeukenList(listView1);
                }
            }          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bevestiging = new Bestelling_bevestiging_form();
            bevestiging.Show();
            bevestiging.FormClosed += new FormClosedEventHandler(bevestiging_FormClosed);
        }

        private void bevestiging_FormClosed(object sender, FormClosedEventArgs e)
        {
            int id = (int)listView1.SelectedItems[0].Tag;

            if ((int)listView1.Items[0].Tag == id)
            {
                listView1.Items[0].Remove();
            }
            if (aanpassen.confirmatie == true)
            {
                bestelOverzichtService.DeleteItem(id, bar);

                foreach (ListViewItem item in listView1.Items)
                {
                    listView1.Items.Remove(item);
                }

                if (bar == true)
                {
                    orderView.FillBarList(listView1);
                }
                else
                {
                    orderView.FillKeukenList(listView1);
                }
            }
        }
    }
}
