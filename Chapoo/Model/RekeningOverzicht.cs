using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public struct RekeningOverzicht
    {
        public string Item { get; set; }
        public int Hoeveelheid { get; set; }
        public double Prijs { get; set; }
        public double TotaalPrijs { get; set; }      

        public RekeningOverzicht(string item, int hoeveelheid, double prijs, double totaalprijs)
        {
            this.Item = item;
            this.Hoeveelheid = hoeveelheid;
            this.Prijs = prijs;
            this.TotaalPrijs = totaalprijs;
        }
    }
}
