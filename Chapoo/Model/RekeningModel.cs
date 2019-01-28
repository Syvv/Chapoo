using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RekeningModel
    {
        public double Totaalbedrag { get; set; }
        public double Btw6 { get; set; }
        public double Btw21 { get; set; }
        public double Fooi { get; set; }
        public string Opmerking { get; set; }
        public Tafel Tafel { get; set; }
        public BestellingModel Bestelling { get; set; }
        public BetaalMethode Methode {get; set;}

        public RekeningModel(double totaalbedrag, double btw6, double btw21, double fooi, string opmerking, Tafel tafel, BestellingModel bestelling, BetaalMethode Methode)
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
        public RekeningModel(double Totaalbedrag, double btw6, double btw21)
        {
            this.Totaalbedrag = Totaalbedrag;
            this.Btw6 = btw6;
            this.Btw21 = btw21;
        }
        
    }
}
