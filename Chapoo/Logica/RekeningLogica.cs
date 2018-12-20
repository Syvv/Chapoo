using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Logica
{
    public class RekeningLogica
    {
        public static double PrijsOptellerMakkelijk()
        {
            List<Menu> besteld = new List<Menu>();
            double totaalRekening = 0;

            foreach(Menu item in besteld)
            {
                if(item.Categorie == 'G')
                {
                    //berekening voor 21%
                }
                else
                {
                    //berekening voor 6%
                }
                totaalRekening += item.prijs;
            }

            return totaalRekening;
        }            
    }
}
