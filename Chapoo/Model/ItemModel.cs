using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public class ItemModel
    {
        public int MenuId { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public Categorie Categorie { get; set; }

        public ItemModel(int menuId, string naam, double prijs, Categorie categorie)
        {
            this.MenuId = menuId;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Categorie = categorie;
        }
        public ItemModel(int menuId)
        {
            this.MenuId = menuId;
        }
    }
}
