using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DataAdaptor;

namespace Logica
{
    public class Fill_orderview_list_logica
    {
        public List<Notificatie> notificaties = Bestel_overzicht_DAO.GetNotificaties();
        public List<Notificatie> barQueue = Bestel_overzicht_DAO.GetBarQueue();
        public List<Notificatie> keukenQueue = Bestel_overzicht_DAO.GetKeukenQueue();

        public void ListViewStyle(ListView listView)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.CheckBoxes = true;
            listView.Scrollable = true;

            listView.Columns.Add("Naam");
            listView.Columns.Add("Aantal");
            listView.Columns.Add("Commentaar");

            listView.Name = "listView";

            listView.Columns[0].Width = 200;
            listView.Columns[1].Width = 78;
            listView.Columns[2].Width = 100;
        }
        public void FillKlaarList(ListView listView)
        {
            for (int i = 0; i < notificaties.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] { notificaties[i].Item, notificaties[i].Aantal.ToString(), notificaties[i].Opmerking});
                lv.Tag = notificaties[i].Id;
                listView.Items.Add(lv);
            }
        }
        public void FillBarList(ListView listView)
        {
            for (int i = 0; i < barQueue.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] { barQueue[i].Item, barQueue[i].Aantal.ToString(), barQueue[i].Opmerking });
                lv.Tag = barQueue[i].Id;
                listView.Items.Add(lv);
            }
        }
        public void FillKeukenList(ListView listView)
        {
            for (int i = 0; i < keukenQueue.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] { keukenQueue[i].Item, keukenQueue[i].Aantal.ToString(), keukenQueue[i].Opmerking });
                lv.Tag = keukenQueue[i].Id;
                listView.Items.Add(lv);
            }
        }
    }
}
