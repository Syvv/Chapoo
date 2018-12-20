using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menu
    {
        //Robbin
        public int MenuId { get; set; }
        public string MenuItem { get; set; }
        public double Prijs { get; set; }
        public char Categorie { get; set; }
        public int Voorraad { get; set; }

        public Menu(int menuId, string menuItem, double prijs, char categorie, int voorraad)
        {
            this.MenuId = menuId;
            this.MenuItem = menuItem;
            this.Prijs = prijs;
            this.Categorie = categorie;
            this.Voorraad = voorraad;
        }
    }
}
