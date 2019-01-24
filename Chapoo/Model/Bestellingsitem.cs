using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestellingsitem : Item
    {               
        public string Commentaar { get; set; }
        public int Hoeveelheid { get; set; }
        public int Tafel { get; set; }
        public DateTime Timestamp { get; set; }

        public Bestellingsitem(string naam, string commentaar, int hoeveelheid,int tafel,
                                int id, DateTime timestamp, double prijs, Categorie categorie) 
                                    : base(id, naam, prijs, categorie)
        {
            this.Commentaar = commentaar;
            this.Hoeveelheid = hoeveelheid;
            this.Tafel = tafel;            
            this.Timestamp = timestamp;
        }
    }
}
