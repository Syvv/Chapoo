using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Styleguide;
using Logica;

namespace UI
{
    public partial class Bestelling_opnemen_form : Style_guide.BaseFormMobile
    {
        Categoriseren_gerechten_logica gerechten = new Categoriseren_gerechten_logica();
        Fill_order_list_logica fillList = new Fill_order_list_logica();
        Lunch_of_Diner_Logica lunchOfDiner = new Lunch_of_Diner_Logica();

        public Bestelling_opnemen_form()
        {
            InitializeComponent();
        }

        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerstuur_Click(object sender, EventArgs e)
        {

        }

        private void btnKoffie_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, gerechten.GetKoffieEnThee()));
        }

        private void btnFris_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, gerechten.GetFrisdranken()));
        }

        private void btnWijn_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, gerechten.GetWijnen()));
        }

        private void btnDrank_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, gerechten.GetGedestileerdeDranken()));
        }

        private void btnTap_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, gerechten.GetBieren()));
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, lunchOfDiner.Nagerechten()));
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {            
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, lunchOfDiner.Hoofdgerechten()));
        }

        private void btnTussen_Click(object sender, EventArgs e)
        {            
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, gerechten.GetTussengerechtenDiner()));
        }

        private void btnVoor_Click(object sender, EventArgs e)
        {            
            DeleteNotChecked();
            this.panel1.Controls.Add(fillList.FillListView(listView1, lunchOfDiner.Voorgerecht()));
            listView1.ItemActivate += new EventHandler(ItemActivate);
        }
        private void ItemActivate(object o, EventArgs e)
        {
            MessageBox.Show("ruft");
        }
        public void DeleteNotChecked()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {

                }
                else
                {
                    listView1.Items.Remove(item);
                }
            }
        }

    }
}
