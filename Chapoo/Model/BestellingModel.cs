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
        public WerknemerModel Werknemer { get; set; }
        public List<BestellingsitemModel> BestelItems { get; set; }
        public TafelModel Tafel { get; set; }

        public BestellingModel(int id, WerknemerModel werknemer, List<BestellingsitemModel> bestelItems)
        {
            this.Id = id;
            this.Werknemer = werknemer;
            this.BestelItems = bestelItems;
        }
        public BestellingModel(WerknemerModel werknemer, TafelModel tafel)
        {
            this.Werknemer = werknemer;
            this.Tafel = tafel;
        }
    }
}
