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
        public CategorieEnum Categorie { get; set; }

        public Item(int menuId, string naam, double prijs, CategorieEnum categorie)
        {
            this.MenuId = menuId;
            this.Naam = naam;
            this.Prijs = prijs;
            this.Categorie = categorie;
        }
        public enum CategorieEnum { LV, LH, LN, DV, DT, DH, DN, F, B, W, G, K}
        /*
         * LV = Lunch Voorgerecht
         * LH = Lunch Hoofdgerecht
         * LN = Lunch Nagerecht
         * DV = Diner Voorgerecht
         * DT = Diner Tussengerecht
         * DH = Diner Hoofdgerecht
         * F  = Frisdrank
         * B  = Bier
         * W  = Wijn
         * G  = Sterke drank
         * K  = Koffie en thee
         */
    }
}
