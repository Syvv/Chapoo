using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rekening
    {
        public double Totaalbedrag { get; set; }
        public double Fooi { get; set; }
        public double Btw6 { get; set; } //btw berekening toevoegen??
        public double Btw21 { get; set; } //btw berekening toevoegen??

        public Rekening(double totaalbedrag, double fooi, double btw6, double btw21)
        {
            this.Totaalbedrag = totaalbedrag;
            this.Fooi = fooi;
            this.Btw6 = btw6;
            this.Btw21 = btw21;
        }

    }
}
