using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Queue_item
    {
        DateTime timestamp;
        public int BestellingId { get; set; }
        public int MenuId { get; set; }
        public int Aantal { get; set; }
        public string Comment { get; set; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        public Queue_item(int bestellingId, int menuId, int aantal, string comment, DateTime time)
        {
            this.BestellingId = bestellingId;
            this.MenuId = menuId;
            this.Aantal = aantal;
            this.Comment = comment;
            Timestamp = time;
        }
    }
}
