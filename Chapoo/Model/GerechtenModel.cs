using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GerechtenModel
    {
        public int menuId { get; set; }
        public string menuItem { get; set; }
        public double prijs { get; set; }
        public char categorie { get; set; }
        public int voorraad { get; set; }

        public GerechtenModel(int menuId, string menuItem, double prijs, char categorie, int voorraad)
        {
            this.menuId = menuId;
            this.menuItem = menuItem;
            this.prijs = prijs;
            this.categorie = categorie;
            this.voorraad = voorraad;
        }
    }
}
