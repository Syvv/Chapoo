using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public int MenuId { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public string Categorie { get; set; }

        public Item(int menuId, string naam, double prijs, string categorie)
        {
            this.MenuId = menuId;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Categorie = categorie;
        }
    }
}
