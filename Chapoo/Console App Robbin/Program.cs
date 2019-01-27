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
            var dao = new TafelDAO();

            dao.TafelVrijMelden(1);
            dao.TafelVrijMelden(2);

            //Console.ReadKey();
        }
    }
}
