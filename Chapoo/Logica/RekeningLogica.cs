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
        public static int Tafelnummer;

        public void TafelNummer(int tafelId)
        {
            Tafelnummer = tafelId;
        }

        public Rekening RekeningOpstellen()
        {
            int Tafelnummer = 1;
            Rekening rekening = PrijsOptellerMakkelijk(Tafelnummer);
            rekening.Opmerking = RekeningToevoegen.Opmerking();
            
            return rekening;
        }
        public Rekening PrijsOptellerMakkelijk(int tafelnummer)
        {
            List<BesteldRekening> besteld = OpvragenBesteldeItems(tafelnummer); 

            double totRekening = 0;
            double zonderBtw = 0;
            double btw21 = 0;
            double btw9 = 0;

            foreach(BesteldRekening item in besteld) //elk item die besteld is
            {
                int hoeveelheid = item.Hoeveelheid;
                if(hoeveelheid < 0) // kan weg
                {
                    hoeveelheid = 0;
                }
                
                while(hoeveelheid != 0)
                {
                    if (item.Categorie == "G" || item.Categorie == "W" || item.Categorie == "B")
                    {
                        //berekening voor 21%
                        Double zonder = (item.Prijs / 121 * 100);
                        double btw = item.Prijs - zonder;

                        btw21 += btw;
                        zonderBtw += zonder;
                    }
                    else
                    {
                        //berekening voor 9%
                        Double zonder = (item.Prijs / 109 * 100);
                        double btw = item.Prijs - zonder;

                        btw9 += btw;
                        zonderBtw += zonder;
                    }
                    totRekening += item.Prijs;
                    hoeveelheid--;
                }
            }
            Decimal totaalRekening = Convert.ToDecimal(totRekening);
            Rekening rekening = new Rekening(totaalRekening, zonderBtw, btw9, btw21, 0, "x", tafelnummer); //fooi moet hier nog bij, en totaalbedrag moet nog veranderd worden.
            return rekening;
        }  
        public bool KloptFooi(Rekening rekening, decimal totaal)
        {
            if(rekening.Totaalbedrag > totaal)
            {
                return true;
            }
            return false;
        }
        public decimal FooiBerekenen(ref Rekening rekening, decimal totaal)
        {
            decimal fooi = totaal - rekening.Totaalbedrag;
            rekening.Totaalbedrag += fooi;

            RekeningToevoegen.Bedragen(fooi, rekening.Totaalbedrag);

            return fooi;
        }
        
        public void OpmerkingToevoegen(string opmerking)
        {
            RekeningToevoegen.zin(opmerking);
        }

        public string OpmerkingWeergeven()
        {
            //voor als er opniew op weergeven opmerking wordt gedrukt
            string opmerking = RekeningToevoegen.Opmerking();

            return opmerking;
        }
        public List<BesteldRekening> OpvragenBesteldeItems(int tafelId)
        {
            var Dao = new RekeningDAO();
            int bestellinId = OpvragenBestellingId(tafelId);

            List<BesteldRekening> item = Dao.OphalenBestellingen(bestellinId);
            return item;
        }
        protected int OpvragenBestellingId(int tafelId)
        {
            var dao = new RekeningDAO();
            //lijst met bestellings id
            List<int> bestellingIdLijst = dao.BestellingIdList(tafelId);

            //lijst met bestellings id in rekening
            List<int> BetaaldeID = dao.BestellingIdInRekening();

            int aantal = bestellingIdLijst.Count;
            int bestellingId = bestellingIdLijst[aantal -1];

            if (BetaaldeID.Contains(bestellingId))
            {
                return 0;
            }
            return bestellingId;
        }

        public void RekeningWegschrijven()
        {
            Rekening rekening = RekeningOpstellen();
            rekening.Opmerking = RekeningToevoegen.Opmerking();
            rekening.Fooi = RekeningToevoegen.RetFooi();
            rekening.Totaalbedrag = RekeningToevoegen.RetTotBedrag();

            var dao = new RekeningDAO();
            int bestellingId = OpvragenBestellingId(rekening.Tafelnummer);

            dao.WegSchrijvenBestelling(rekening, rekening.Tafelnummer, bestellingId);
        }

        public List<RekeningOverzicht>OverzichtBestellingen(int tafelId)
        {
            //voor de Gridview
            var Dao = new RekeningDAO();
            int bestellinId = OpvragenBestellingId(tafelId);

            List<BesteldRekening> item = Dao.OphalenBestellingen(bestellinId);
            List<RekeningOverzicht> rekening = new List<RekeningOverzicht>();

            List<string> besteld = new List<string>(); //moet eruit voor consult

            foreach(BesteldRekening x in item)
            {
                if (!besteld.Contains(x.MenuItem))
                {
                    RekeningOverzicht rk = new RekeningOverzicht();
                    rk.Item = x.MenuItem;
                    rk.Hoeveelheid = x.Hoeveelheid;
                    rk.Prijs = x.Prijs;
                    rk.TotaalPrijs = x.Hoeveelheid * x.Prijs;

                    rekening.Add(rk);
                    besteld.Add(x.MenuItem); //eruit voor consult
                }                
            }
            return rekening;
        }
    }
}
