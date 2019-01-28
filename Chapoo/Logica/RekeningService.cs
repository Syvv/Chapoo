using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class RekeningService
    {
        private RekeningDAO RekeningDataLaag;
        private BestellingsItemDAO BestellingDao;
        private DAOFactory Factory;

        public RekeningService(DAOFactory factory)
        {
            this.Factory = factory;
            RekeningDataLaag = Factory.CreateRekeningDAO();
            BestellingDao = Factory.CreateBestellingsItemDAO();
        }

        private string Opmerking { get; set; }
        private int BestellingsId { get; set; }

        public List<BestellingsitemModel> BesteldeItems(int bestellingsId)
        {
            List<BestellingsitemModel> besteldeItems = BestellingDao.HaalAlleItemsOp(bestellingsId);

            return besteldeItems;
        }

        //rekening opstellen Prijs
        public RekeningModel RekeningOpstellen()//Test de While Loop
        {
            List<BestellingsitemModel> besteldeItems = BesteldeItems(BestellingsId);

            double btw21 = 0;
            double btw09 = 0;
            double totaalBedrag = 0;

            foreach(BestellingsitemModel item in besteldeItems)
            {
                while(item.Hoeveelheid > 0) //Deze testen
                {
                    if(item.Categorie == Categorie.SterkeDrank|| item.Categorie == Categorie.Wijn || item.Categorie == Categorie.Bier)
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
            RekeningModel rekening = new RekeningModel(totaalBedrag, btw09, btw21);

            return rekening;
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

        //Fooi toevoegenbij Eindbedrag invullen
        public void FooiToevoegen(RekeningModel rekening, double totaal)
        {
            double fooi = totaal - rekening.Totaalbedrag;
            rekening.Totaalbedrag += fooi;            
        }

        //Fooi Controlleren bij Eindbedrag invullen
        public bool FooiControlleren(RekeningModel rekening, double totaal)
        {
            if (rekening.Totaalbedrag > totaal)
            {
                return true;
            }
            return false;
        }
        //fooi handmatig toevoegen als er los fooi gegeven wordt.
        public double NieuwTotaalbedrag(double fooi, RekeningModel rekening)
        {
            rekening.Fooi = fooi;
            rekening.Totaalbedrag += fooi;

            return rekening.Totaalbedrag;
        }

        //rekening versturen
        public void RekeningBetalen()//naam verbeteren, fooi en nieuw eindbedrag nog toevoegen
        {
            RekeningModel rekening = RekeningOpstellen();
            rekening.Opmerking = Opmerking;

            //fooi en niew eindbedragtoevoegen

            RekeningDataLaag.InsertRekening(rekening);
        }
    }
}
