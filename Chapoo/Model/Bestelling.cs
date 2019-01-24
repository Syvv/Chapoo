using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        public int Id { get; set; }
        public Werknemer Werknemer { get; set; }
        public List<Bestellingsitem> BestelItems { get; set; }

        public Bestelling(int id, Werknemer werknemer, List<Bestellingsitem> bestelItems)
        {
            this.Id = id;
            this.Werknemer = werknemer;
            this.BestelItems = bestelItems;
        }
    }
}
