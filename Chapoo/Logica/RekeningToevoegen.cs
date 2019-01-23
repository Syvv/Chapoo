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
        static string text = "doen";
        static decimal Fooi;
        static decimal TotaalBedrag;
        public static void zin(string zin)
        {
            text = zin;
        }

        public static string Opmerking()
        {
            return text;
        }

        public static void Bedragen(decimal fooi, decimal eindbedrag)
        {
            Fooi = fooi;
            TotaalBedrag = eindbedrag;
        }
        public static decimal retFooi()
        {
            return Fooi;
        }
        public static decimal RetTotBedrag()
        {
            return TotaalBedrag;
        }
    }
}
