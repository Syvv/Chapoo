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
        //Rekening rekening;
        public Rekening RekeningOpstellen() //weet nog niet of dit wel handig is
        {
            Rekening rekening = new Rekening(0, 0, 0, 0, 0, " ");
            rekening = PrijsOptellerMakkelijk();

            return rekening;
        }
        public Rekening PrijsOptellerMakkelijk() //tafelnummer toevoegen
        {
            List<BesteldRekening> besteld = OpvragenBesteldeItems(1); //hier moet nog een tafelnummer

            double totaalRekening = 0;
            double zonderBtw = 0;
            double btw21 = 0;
            double btw6 = 0;

            foreach(BesteldRekening item in besteld) //elk item die besteld is
            {
                while(item.Hoeveelheid != 0)
                {
                    if (item.Categorie == "G")
                    {
                        //berekening voor 21%
                        Double zonder = (item.Prijs / 121 * 100);
                        double btw = item.Prijs - zonder;

                        btw21 += btw;
                        zonderBtw += zonder;
                    }
                    else
                    {
                        //berekening voor 6%
                        Double zonder = (item.Prijs / 106 * 100);
                        double btw = item.Prijs - zonder;

                        btw6 += btw;
                        zonderBtw += zonder;
                    }
                    totaalRekening += item.Prijs;
                    item.Hoeveelheid--;
                }
            }

            Rekening rekening = new Rekening(totaalRekening, zonderBtw, btw6, btw21, 0, null); //fooi moet hier nog bij, en totaalbedrag moet nog veranderd worden.
            return rekening;
        }  

        public void FooiBerekenen(int ingevoerdbedrag, ref Rekening rekening) //ergens nog een controller plaatsen om te kijken of er geen lager bedrag is ingevoerd dan dr rekening zelf
        {
            double fooi = ingevoerdbedrag - rekening.Totaalbedrag;
            rekening.Fooi = fooi;
            rekening.Totaalbedrag = rekening.Totaalbedrag + fooi;
        }

        public void OpmerkingToevoegen(string opmerking)
        {
            Rekening rekening = RekeningOpstellen();
            rekening.Opmerking = opmerking;

            //nu nog opslaan
        }
        public string OpmerkingWeergeven()
        {
            //voor als er opniew op weergeven opmerking wordt gedrukt
            Rekening rekening = RekeningOpstellen();
            string opmerking = rekening.Opmerking;

            return opmerking;
        }
        public List<BesteldRekening> OpvragenBesteldeItems(int tafelId)
        {
            var Dao = new RekeningDAO();
            int bestellinId = OpvragenBestellingId(tafelId);

            List<BesteldRekening> item = Dao.OphalenBestellingen(bestellinId);
            return item;
        }
        public int OpvragenBestellingId(int tafelId)//protected
        {
            var dao = new RekeningDAO();
            List<int> bestellingIdLijst = dao.BestellingIdList(tafelId);

            int aantal = bestellingIdLijst.Count;
            int bestellingId = bestellingIdLijst[aantal -1];

            return bestellingId;
        }

        public void RekeningWegschrijven(int tafelId)
        {
            Rekening rekening = RekeningOpstellen();
            var dao = new RekeningDAO();
            int bestellingId = OpvragenBestellingId(tafelId);

            dao.WegSchrijvenBestelling(rekening, tafelId, bestellingId);
        }
    }
}
