using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class RekeningLogica
    {
        private RekeningDAO RekeningDataLaag = new RekeningDAO();
        public string Opmerking { get; set; }
        public int BestellingsId { get; set; }

        public List<Bestellingsitem> BesteldeItems(int bestellingsId)
        {
            List<Bestellingsitem> besteldeItems = RekeningDataLaag.OphalenBestellingen(bestellingsId);

            return besteldeItems;
        }

        //rekening opstellen Prijs
        public void RekeningOpstellen()//Test de While Loop
        {
            List<Bestellingsitem> besteldeItems = BesteldeItems(BestellingsId);

            double btw21 = 0;
            double btw09 = 0;
            double totaalBedrag = 0;

            foreach(Bestellingsitem item in besteldeItems)
            {
                while(item.Hoeveelheid > 0) //Deze testen
                {
                    if(item.Categorie == Categorie.G|| item.Categorie == Categorie.W || item.Categorie == Categorie.B)
                    {
                        double btw = item.Prijs - (item.Prijs / 121 * 100);
                        btw21 += btw;
                    }
                    else
                    {
                        double btw = item.Prijs - (item.Prijs / 109 * 100);
                        btw09 += btw;
                    }
                    totaalBedrag += item.Prijs;
                }
            }
            double db_btw = btw21 + btw09;
        }

        //Opmerking toevoegen
        public void OpmerkingToevoegen(string opmerking)
        {
            this.Opmerking = opmerking;
        }
        //Opmerking Weergeven
        public string OpmerkingWeergeven()
        {
            return (string) Opmerking;
        }

        //Fooi toevoegen
        public void FooiToevoegen(double fooi)
        {

        }

        //Fooi Controlleren
        public bool FooiControlleren(double Fooi)
        {
            return false;
        }

        //rekening versturen
        public void RekeningAfsluiten(Rekening rekening)
        {

        }
    }
}
