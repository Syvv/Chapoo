using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestellingModel
    {
        public int Id { get; set; }
        public Werknemer Werknemer { get; set; }
        public List<Bestellingsitem> BestelItems { get; set; }
        public Tafel Tafel { get; set; }

        public BestellingModel(int id, Werknemer werknemer, List<Bestellingsitem> bestelItems)
        {
            this.Id = id;
            this.Werknemer = werknemer;
            this.BestelItems = bestelItems;
        }
        public BestellingModel(Werknemer werknemer, Tafel tafel)
        {
            this.Werknemer = werknemer;
            this.Tafel = tafel;
        }
    }
}
