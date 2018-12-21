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
        public static double PrijsOptellerMakkelijk()
        {
            List<Menu> besteld = new List<Menu>();
            double totaalRekening = 0;
            double zonderBtw = 0;
            double btw21 = 0;
            double btw6 = 0;

            foreach(Menu item in besteld)
            {
                if(item.Categorie == 'G')
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
            return totaalRekening;
        }  
        public int FooiBerekenen(int rekening)
        {
            return 0;
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
        public List<Menu> Weergeven()
        {
            var Dao = new RekeningDAO();
            List<Menu> item = Dao.OphalenBestellingen(0);
            return item;
        }
    }
}
