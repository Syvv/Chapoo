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
            var manager = new RekeningLogica();
            List<Menu> menu= manager.Test();
            

            foreach(Menu item in menu)
            {
                Console.WriteLine(item.MenuItem);
            }
            Console.ReadKey();
        }
    }
}
