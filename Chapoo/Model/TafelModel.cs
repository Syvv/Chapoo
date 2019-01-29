using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TafelModel
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public int Zitplaatsen { get; set; }
        public BestellingModel Bestelling { get; set; }

        public TafelModel(int id, Status status, int zitplaatsen, BestellingModel bestelling)
        {
            this.Id = id;
            this.Status = status;
            this.Zitplaatsen = zitplaatsen;
            this.Bestelling = bestelling;
        }
        public TafelModel(int tafelId)
        {
            this.Id = tafelId;
        }
        
    }
}
