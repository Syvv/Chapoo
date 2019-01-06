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

        public static Rekening PrijsOptellerMakkelijk()
        {
            List<Menu> besteld = new List<Menu>(); //hier komt ophalen menu items(die besteld zijn)
            double totaalRekening = 0;
            double zonderBtw = 0;
            double btw21 = 0;
            double btw6 = 0;

            foreach(Menu item in besteld) //elk item die besteld is
            {
                if(item.Categorie == "G")
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
            }

            Rekening rekening = new Rekening(totaalRekening, zonderBtw, btw6, btw21, 0); //fooi moet hier nog bij, en totaalbedrag moet nog veranderd worden.
            return rekening;
        }  
        public void FooiBerekenen(int ingevoerdbedrag, Rekening rekening) //ergens nog een controller plaatsen om te kijken of er geen lager bedrag is ingevoerd dan dr rekening zelf
        {
            double fooi = ingevoerdbedrag - rekening.Totaalbedrag;
            rekening.Fooi = fooi;
            rekening.Totaalbedrag = rekening.Totaalbedrag + fooi;
        }

        public List<Menu> OpvragenBesteldeItems(int tafelId)
        {
            var Dao = new RekeningDAO();
            int bestellinId = OpvragenBestellingId(tafelId);

            List<Menu> item = Dao.OphalenBestellingen(bestellinId);
            return item;
        }
        protected int OpvragenBestellingId(int tafelId)
        {
            var dao = new RekeningDAO();
            return dao.BestellingIdOpvragen(tafelId);
        }
    }
}
