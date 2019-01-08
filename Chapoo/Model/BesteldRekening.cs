using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BesteldRekening : Menu
    {
        public int Hoeveelheid { get; set; }

        public BesteldRekening(int menu_id, string item, double prijs,string categorie, int voorraad, int hoeveelheid) : base(menu_id, item, prijs, categorie, voorraad)
        {
            this.Hoeveelheid = hoeveelheid;
        }
    }
}
