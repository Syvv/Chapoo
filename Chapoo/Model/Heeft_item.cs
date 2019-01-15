using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Heeft_item
    {
        public int BestellingId { get; set; }
        public int MenuId { get; set; }
        public int Aantal { get; set; }

        public Heeft_item(int bestellingId, int menuId, int aantal)
        {
            BestellingId = bestellingId;
            MenuId = menuId;
            Aantal = aantal;
        }
        public class HeeftItemList
        {
            static List<Queue_item> list = new List<Queue_item>();
            public static List<Queue_item> List { get => list; set => list = value; }
        }
    }
}
