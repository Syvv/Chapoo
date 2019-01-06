﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class Bestelling_logica
    {
        public MenuItem_DAO MenuItem = new MenuItem_DAO();
        public List<Bestelling> BestellingList = new List<Bestelling>();
        public List<Queue_item> BarqueueList = new List<Queue_item>();
        public List<Queue_item> KeukenqueueList = new List<Queue_item>();
        public int BestellingId;

        public void InsertBestelling(int tafelId, int werknemerId)
        {
            BestellingId = MenuItem.InsertMenuItem(tafelId, werknemerId);
        }
        public void MakeQueueList(int menuId, int aantal, string comment, string categorie)
        {
            
            Queue_item QueueItem = new Queue_item(BestellingId, menuId, aantal, comment);
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
    }
}
