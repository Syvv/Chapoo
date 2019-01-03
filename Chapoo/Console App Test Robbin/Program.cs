using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Logica;

namespace Console_App_Test_Robbin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var manager = new RekeningLogica();
            List<Menu> menu = manager.Weergeven();
            

            foreach(Menu item in menu)
            {
                Console.WriteLine(item.MenuItem);
            }
            */
            var instantie = new Categoriseren_gerechten_logica();
            var LunchOfDiner = new Lunch_of_Diner_Logica();
           // List<Menu> voorgerechten = instantie.GetVoorgerechtenLunch();
            List<Menu> voorgerechten = LunchOfDiner.Voorgerecht();

            foreach (Menu item in voorgerechten)
            {
                Console.WriteLine(item.MenuItem);
            }
            Console.ReadKey();
        }

        
    }
}
