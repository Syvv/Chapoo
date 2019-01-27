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
        public StatusType Status { get; set; }
        public int Zitplaatsen { get; set; }
        public Bestelling Bestelling { get; set; }

        public Tafel(int id, StatusType status, int zitplaatsen, Bestelling bestelling)
        {
            Id = id;
            Status = status;
            Zitplaatsen = zitplaatsen;
            Bestelling = bestelling;
        }
        public enum StatusType
        {
            vrij, bezet
        }
    }
}
