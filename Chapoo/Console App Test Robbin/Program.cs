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
            try
            {
                //var data = new RekeningDAO();
                //int test = data.BestellingIdOpvragen(1);
                //Console.WriteLine(test);

                var logica = new RekeningLogica();
                Console.WriteLine(logica.OpvragenBestellingId(1));
            }
            catch
            {
                Console.WriteLine("niet gelukt");
            }
            finally { Console.ReadKey(); }
        }
    }
}
