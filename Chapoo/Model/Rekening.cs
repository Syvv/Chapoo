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
        public double Btw { get; set; }
        public double Fooi { get; set; }
        public string Opmerking { get; set; }
        public Tafel Tafel { get; set; }
        public Bestelling Bestelling { get; set; }
        public BetaalMethode Methode {get; set;}

        public Rekening(double totaalbedrag, double btw, double fooi, string opmerking, Tafel tafel, Bestelling bestelling, BetaalMethode Methode)
        {
            this.Totaalbedrag = totaalbedrag;
            this.Fooi = fooi;
            this.Btw = btw;
            this.Opmerking = opmerking;
            this.Tafel = tafel;
            this.Bestelling = bestelling;
            this.Methode = Methode;
        }

        public enum BetaalMethode
        {
            pin, cash, creditcard
        }
    }
}
