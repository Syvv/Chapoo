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
        public double BedragZonderBtw { get; set; }
        public double Btw9 { get; set; } //btw berekening toevoegen??
        public double Btw21 { get; set; } //btw berekening toevoegen??
        public double Fooi { get; set; }
        public string Opmerking { get; set; }

        public Rekening(double totaalbedrag,double bedragZonderBtw, double btw9, double btw21, double fooi, string opmerking)
        {
            this.Totaalbedrag = totaalbedrag;
            this.BedragZonderBtw = bedragZonderBtw;
            this.Fooi = fooi;
            this.Btw9 = btw9;
            this.Btw21 = btw21;
            this.Opmerking = opmerking;
        }

    }
}
