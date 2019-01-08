using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Logica;
using DataAdaptor;

namespace Console_App_Test_Robbin
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new RekeningDAO();
            List<BesteldRekening> besteld = data.OphalenBestellingen(88);

            foreach (BesteldRekening item in besteld)
            {
                Console.WriteLine(item.MenuItem);
            }
            try
            {
                

                //var logica = new RekeningLogica();
                //Console.WriteLine(logica.OpvragenBestellingId(1));
            }
            catch
            {
                Console.WriteLine("niet gelukt");
            }
            finally { Console.ReadKey(); }
        }
    }
}
