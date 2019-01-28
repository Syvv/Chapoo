using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItemModel : ItemModel
    {
        public int Voorraad { get; set; }

        public MenuItemModel(int menuId, string naam, double prijs, Categorie categorie, int voorraad) : base(menuId, naam, prijs, categorie)
        {
            this.Voorraad = voorraad;
        }
    }
}
