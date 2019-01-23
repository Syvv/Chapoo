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
        private BestelOverzichtService bestelOverzichtService = new BestelOverzichtService();
        private Bestelling_bevestiging_form verwijder;
        private Bestelling_overzicht_aanpassen_form aanpassen;
        private bool bar = false;
        private VulBestelOverzichtService orderView = new VulBestelOverzichtService();
        private ListStyleUI listStyle = new ListStyleUI();
        public Bestelling_overzicht_form()
        {
            InitializeComponent();
            listStyle.StyleBestellingOverzicht(listView1);
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
            verwijder = new Bestelling_bevestiging_form();
            verwijder.Show();
            verwijder.FormClosed += new FormClosedEventHandler(DeleteAllBevestiging_FormClosed);
        }

        private void DeleteAllBevestiging_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(verwijder.confirmatie)
            {
                foreach(ListViewItem item in listView1.Items)
                {
                    int id = (int)item.Tag;
                    bestelOverzichtService.DeleteAll(id, bar);
                }
                if (bar)
                {
                    orderView.FillBarList(listView1);
                }
                else
                {
                    orderView.FillKeukenList(listView1);
                }
            }
             verwijder.confirmatie = false;
        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillKlaarList(listView1);
            btnChange.Hide(); btnDeleteAll.Hide(); btnDelete.Hide();
            btnAllesBezorgd.Show(); btnBezorgd.Show();
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillBarList(listView1);
            btnChange.Show();
            btnDeleteAll.Show();
            btnDelete.Show();
            btnAllesBezorgd.Hide(); btnBezorgd.Hide();
            bar = true;
        }

        private void btnKeuken_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            orderView.FillKeukenList(listView1);
            btnChange.Show();
            btnDeleteAll.Show();
            btnDelete.Show();
            btnAllesBezorgd.Hide(); btnBezorgd.Hide();
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
            if(aanpassen.confirmatie)
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
            verwijder = new Bestelling_bevestiging_form();
            verwijder.Show();
            verwijder.FormClosed += new FormClosedEventHandler(DeleteBevestiging_FormClosed);
        }

        private void DeleteBevestiging_FormClosed(object sender, FormClosedEventArgs e)
        {
            int id = (int)listView1.SelectedItems[0].Tag;

            if ((int)listView1.Items[0].Tag == id)
            {
                listView1.Items[0].Remove();
            }
            if (verwijder.confirmatie)
            {
                bestelOverzichtService.DeleteItem(id, bar);

                if (bar)
                {
                    orderView.FillBarList(listView1);
                }
                else
                {
                    orderView.FillKeukenList(listView1);
                }
                verwijder.confirmatie = false;
            }
        }

        private void btnBezorgd_Click(object sender, EventArgs e)
        {
            int id = (int)listView1.SelectedItems[0].Tag;

            if ((int)listView1.Items[0].Tag == id)
            {
                listView1.Items[0].Remove();
                bestelOverzichtService.DeleteFromNotifications(id);
            }

            orderView.FillKlaarList(listView1);
        }

        private void btnAllesBezorgd_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.Items)
            {
                int index = item.Index;

                int id = (int)listView1.Items[index].Tag;
                listView1.Items[index].Remove();
                bestelOverzichtService.DeleteFromNotifications(id);
            }
            orderView.FillKlaarList(listView1);
        }
    }
}
