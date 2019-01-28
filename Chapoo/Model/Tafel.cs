using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        public int Id { get; set; }
        public Status Statuss { get; set; }
        public int Zitplaatsen { get; set; }
        public Bestelling Bestelling { get; set; }

        public Tafel(int id, Status status, int zitplaatsen, Bestelling bestelling)
        {
            this.Id = id;
            this.Statuss = status;
            this.Zitplaatsen = zitplaatsen;
            this.Bestelling = bestelling;
        }
        public Tafel(int tafelId)
        {
            this.Id = tafelId;
        }
        
    }
}
