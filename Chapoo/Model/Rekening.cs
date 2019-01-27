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
        public double Btw6 { get; set; }
        public double Btw21 { get; set; }
        public double Fooi { get; set; }
        public string Opmerking { get; set; }
        public Tafel Tafel { get; set; }
        public Bestelling Bestelling { get; set; }
        public BetaalMethode Methode {get; set;}

        public Rekening(double totaalbedrag, double btw6, double btw21, double fooi, string opmerking, Tafel tafel, Bestelling bestelling, BetaalMethode Methode)
        {
            this.Totaalbedrag = totaalbedrag;
            this.Fooi = fooi;
            this.Btw6 = btw6;
            this.Btw21 = Btw21;
            this.Opmerking = opmerking;
            this.Tafel = tafel;
            this.Bestelling = bestelling;
            this.Methode = Methode;
        }
        public Rekening(double Totaalbedrag, double btw6, double btw21)
        {
            this.Totaalbedrag = Totaalbedrag;
            this.Btw6 = btw6;
            this.Btw21 = btw21;
        }

        public enum BetaalMethode
        {
            nog_niet, pin, cash, creditcard
        }
    }
}
