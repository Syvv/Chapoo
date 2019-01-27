using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAdaptor;
using Model;

namespace Console_App_Robbin
{
    class Program
    {
        static void Main(string[] args)
        {
            var rekeningDao = new Nieuwe_RekeningDAO();

            List<Bestellingsitem> lijst = rekeningDao.OphalenBestellingen(1);

            foreach(Bestellingsitem i in lijst)
            {
                Console.WriteLine(i.Naam);
            }
            Console.ReadKey();
        }
    }
}
