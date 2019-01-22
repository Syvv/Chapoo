using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HeeftItemModel
    {
        public int BestellingId { get; set; }
        public int MenuId { get; set; }
        public int Aantal { get; set; }

        public HeeftItemModel(int bestellingId, int menuId, int aantal)
        {
            BestellingId = bestellingId;
            MenuId = menuId;
            Aantal = aantal;
        }
        public class HeeftItemList
        {
            static List<QueueItemModel> list = new List<QueueItemModel>();
            public static List<QueueItemModel> List { get => list; set => list = value; }
        }
    }
}
