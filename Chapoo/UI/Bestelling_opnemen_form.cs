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
using Model;

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
            fillList.ListViewStyle(listView1);
        }

        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            SendOrder();
        }

        private void btnKoffie_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            fillList.FillListView(listView1, gerechten.GetKoffieEnThee());
        }

        private void btnFris_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            fillList.FillListView(listView1, gerechten.GetFrisdranken());
        }

        private void btnWijn_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            fillList.FillListView(listView1, gerechten.GetWijnen());
        }

        private void btnDrank_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            fillList.FillListView(listView1, gerechten.GetGedestileerdeDranken());
        }

        private void btnTap_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            fillList.FillListView(listView1, gerechten.GetBieren());
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            DeleteNotChecked();
            fillList.FillListView(listView1, lunchOfDiner.Nagerechten());
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {            
            DeleteNotChecked();
            fillList.FillListView(listView1, lunchOfDiner.Hoofdgerechten());
        }

        private void btnTussen_Click(object sender, EventArgs e)
        {            
            DeleteNotChecked();
            fillList.FillListView(listView1, gerechten.GetTussengerechtenDiner());
        }

        private void btnVoor_Click(object sender, EventArgs e)
        {            
            DeleteNotChecked();
            fillList.FillListView(listView1, lunchOfDiner.Voorgerecht());
            listView1.ItemActivate += new EventHandler(ItemActivate);
        }
        private void ItemActivate(object o, EventArgs e)
        {
            using(var opmerking = new Bestelling_opnemen_opmerking_form(this))
            {
                opmerking.ShowDialog();
            }
        }
        public void ChangeComment(string comment)
        {
            listView1.SelectedItems[0].SubItems[2].Text = comment;
        }
        public void DeleteNotChecked()
        {
            foreach (ListViewItem item in listView1.Items)
            {
                int index = item.Index;

                if (item.Checked)
                {
     
                }
                else
                {
                    listView1.Items.Remove(item);
                }
            }
        }
        public void SendOrder()
        {
            Bestelling_logica bestellingLogica = new Bestelling_logica();

            bestellingLogica.InsertBestelling(1, 1);

            foreach (ListViewItem item in listView1.Items)
            {
                int index = item.Index;
  
                int menuId = 0;
                string menuIdString = this.listView1.Items[index].SubItems[0].Text;
                string comment = listView1.Items[index].SubItems[2].ToString();
                string categorie = item.Tag.ToString();

                //Converteer de id van string naar int
                if (!Int32.TryParse(menuIdString, out menuId))
                {
                    menuId = -1;
                }

                if (item.Checked == false)
                {
                    listView1.Items.Remove(item);
                }
                else
                {                  
                    bestellingLogica.MakeQueueList(menuId, 1, comment, categorie);
                }
            }
            
            bestellingLogica.InsertQueue();
            listView1.Clear();
        }

    }
}
