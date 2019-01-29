using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestellingsitemModel : ItemModel
    {               
        public string Commentaar { get; set; }
        public int Hoeveelheid { get; set; }
        public int Tafel { get; set; }
        public DateTime Timestamp { get; set; }
        public int BestellingsId { get; set; }
        public BestellingsItemStatus Status { get; set; }


        public BestellingsitemModel(string naam, string commentaar, int hoeveelheid, int tafelId,
                                int id, DateTime timestamp, double prijs, Categorie categorie, int bestellingsId, BestellingsItemStatus status):base(id,naam,prijs,categorie)
        {
            this.Commentaar = commentaar;
            this.Hoeveelheid = hoeveelheid;
            this.Tafel = tafelId;
            this.Timestamp = timestamp;
            this.BestellingsId = bestellingsId;
            this.Status = status;
        }
        public int BtwPercentage { get; set; }

        public BestellingsitemModel(string naam, string commentaar, int hoeveelheid,int tafelId,
                                int id, DateTime timestamp, double prijs, Categorie categorie, int bestellingsId, int btwPercentage) 
                                    : base(id, naam, prijs, categorie)
        {
            this.Commentaar = commentaar;
            this.Hoeveelheid = hoeveelheid;
            this.Tafel = tafelId;
            this.Timestamp = timestamp;
            this.BestellingsId = bestellingsId;
            this.BtwPercentage = btwPercentage;
        }
        public BestellingsitemModel(int menuId, int bestellingId, DateTime timestamp, 
            int hoeveelheid, string commentaar) : base(menuId)
        {
            this.BestellingsId = bestellingId;
            this.Timestamp = timestamp;
            this.Hoeveelheid = hoeveelheid;
            this.Commentaar = commentaar;
        }
    }
}
