using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class BestellingService
    {
        public BestellingOpnemenDAO MenuItem = new BestellingOpnemenDAO();
        public List<Bestelling> BestellingList = new List<Bestelling>();
        public List<QueueItemModel> BarqueueList = new List<QueueItemModel>();
        public List<QueueItemModel> KeukenqueueList = new List<QueueItemModel>();
        public List<HeeftItemModel> HeeftItemList = new List<HeeftItemModel>();
        public int BestellingId;

        public void InsertBestelling(int tafelId, int werknemerId)
        {
            BestellingId = MenuItem.InsertMenuItem(tafelId, werknemerId);
        }
        public void MakeQueueList(int menuId, int aantal, string comment, string categorie)
        {
            
            QueueItemModel QueueItem = new QueueItemModel(BestellingId, menuId, aantal, comment, DateTime.Now);
            if((categorie == "F") || (categorie == "B") || (categorie == "W") || (categorie == "G") || (categorie == "K"))
            {
                BarqueueList.Add(QueueItem);
            }
            else
            {
                KeukenqueueList.Add(QueueItem);
            }
            
        }
        public void InsertQueue()
        {
            if(KeukenqueueList.Any())
            {
                MenuItem.InsertInKeukenqueue(KeukenqueueList);
            }
            if (BarqueueList.Any())
            {
                MenuItem.InsertInBarqueue(BarqueueList);
            }
        }
        public void MakeItemList(int menuId, int aantal)
        {
            HeeftItemModel item = new HeeftItemModel(BestellingId, menuId, aantal);
            HeeftItemList.Add(item);
        }
        public void InsertItem()
        {
            MenuItem.InsertInHeeftItem(HeeftItemList);
        }
    }
}
