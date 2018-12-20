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
                totaalRekening += item.Prijs;
            }

            return totaalRekening;
        }  
        public List<Menu> Test()
        {
            var productManager = new RekeningDAO();
            //return productManager.GetTest();
            return null;
        }
    }
}
