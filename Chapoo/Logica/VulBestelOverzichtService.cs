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
    public class VulBestelOverzichtService
    {
        private List<BestelOverzichtItemModel> notificaties;
        private List<BestelOverzichtItemModel> barQueue;
        private List<BestelOverzichtItemModel> keukenQueue;

        public void FillKlaarList(ListView listView)
        {
            notificaties = BestellingOverzichtDAO.GetNotificaties();

            for (int i = 0; i < notificaties.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] { notificaties[i].Item, notificaties[i].Aantal.ToString(), notificaties[i].Opmerking});
                lv.Tag = notificaties[i].Id;
                listView.Items.Add(lv);
            }
        }
        public void FillBarList(ListView listView)
        {
            barQueue = BestellingOverzichtDAO.GetBarQueue();

            for (int i = 0; i < barQueue.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] { barQueue[i].Item, barQueue[i].Aantal.ToString(), barQueue[i].Opmerking });
                lv.Tag = barQueue[i].Id;
                listView.Items.Add(lv);
            }
        }
        public void FillKeukenList(ListView listView)
        {
            keukenQueue = BestellingOverzichtDAO.GetKeukenQueue();

            for (int i = 0; i < keukenQueue.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] { keukenQueue[i].Item, keukenQueue[i].Aantal.ToString(), keukenQueue[i].Opmerking });
                lv.Tag = keukenQueue[i].Id;
                listView.Items.Add(lv);
            }
        }
    }
}
