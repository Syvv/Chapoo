using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class RekeningToevoegen 
    {
        static string text;
        public static void zin(string zin)
        {
            text = zin;
        }

        public static string zinnen()
        {
            return text;
        }
    }
}
