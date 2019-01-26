using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem : Item
    {
        public int Voorraad { get; set; }

        public MenuItem(int menuId, string naam, double prijs, CategorieEnum categorie, int voorraad) : base(menuId, naam, prijs, categorie)
        {
            this.Voorraad = voorraad;
        }
    }
}
