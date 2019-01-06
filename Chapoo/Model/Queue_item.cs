using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Queue_item
    { 
        public int BestellingId { get; set; }
        public int MenuId { get; set; }
        public int Aantal { get; set; }
        public string Comment { get; set; }

        public Queue_item(int bestellingId, int menuId, int aantal, string comment)
        {
            BestellingId = bestellingId;
            MenuId = menuId;
            Aantal = aantal;
            Comment = comment;
        }
        public class KeukenqueueList
        {
            static List<Queue_item> list = new List<Queue_item>();
            public static List<Queue_item> List { get => list; set => list = value; }
        }
        public class BarqueueList
        {
            static List<Queue_item> list = new List<Queue_item>();
            public static List<Queue_item> List { get => list; set => list = value; }
        }
    }
}
