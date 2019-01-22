using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuModel
    {
        public int MenuId { get; set; }
        public string MenuItem { get; set; }
        public double Prijs { get; set; }
        public string Categorie { get; set; }
        public int Voorraad { get; set; }

        public MenuModel(int menuId, string menuItem, double prijs, string categorie, int voorraad)
        {
            this.MenuId = menuId;
            this.MenuItem = menuItem;
            this.Prijs = prijs;
            this.Categorie = categorie;
            this.Voorraad = voorraad;
        }
    }
}
