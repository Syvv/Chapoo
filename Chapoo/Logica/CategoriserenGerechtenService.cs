using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    /*
     * Iedere functie in dit bestand haalt de menu items uit het menu
     * aan de hand van een code. Vervolgens worden die items in een list gezet.
     */
    public class CategoriserenGerechtenService {

        List<MenuModel> menu = MenuDAO.GetMenuItems();
        
        public List<MenuModel> GetVoorgerechtenLunch()
        {
            List<MenuModel> voorgerechtenLunch = new List<MenuModel>();

            for(int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LV")
                {
                    voorgerechtenLunch.Add(menu[i]);
                }
            }

            return voorgerechtenLunch;
        }
        public List<MenuModel> GetHoofdgerechtenLunch()
        {
            List<MenuModel> hoofdgerechtenLunch = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LH")
                {
                    hoofdgerechtenLunch.Add(menu[i]);
                }
            }

            return hoofdgerechtenLunch;
        }
        public List<MenuModel> GetNagerechtenLunch()
        {
            List<MenuModel> nagerechtenLunch = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LN")
                {
                    nagerechtenLunch.Add(menu[i]);
                }
            }

            return nagerechtenLunch;
        }
        public List<MenuModel> GetVoorgerechtenDiner()
        {
            List<MenuModel> voorgerechtenDiner = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DV")
                {
                    voorgerechtenDiner.Add(menu[i]);
                }
            }

            return voorgerechtenDiner;
        }
        public List<MenuModel> GetTussengerechtenDiner()
        {
            List<MenuModel> tussengerechtenDiner = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DT")
                {
                    tussengerechtenDiner.Add(menu[i]);
                }
            }

            return tussengerechtenDiner;
        }
        public List<MenuModel> GetHoofdgerechtenDiner()
        {
            List<MenuModel> hoofgerechtenDiner = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DH")
                {
                    hoofgerechtenDiner.Add(menu[i]);
                }
            }

            return hoofgerechtenDiner;
        }
        public List<MenuModel> GetNagerechtenDiner()
        {
            List<MenuModel> nagerechtenDiner = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DN")
                {
                    nagerechtenDiner.Add(menu[i]);
                }
            }

            return nagerechtenDiner;
        }
        public List<MenuModel> GetFrisdranken()
        {
            List<MenuModel> frisdranken = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "F")
                {
                    frisdranken.Add(menu[i]);
                }
            }

            return frisdranken;
        }
        public List<MenuModel> GetBieren()
        {
            List<MenuModel> bieren = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "B")
                {
                    bieren.Add(menu[i]);
                }
            }

            return bieren;
        }
        public List<MenuModel> GetWijnen()
        {
            List<MenuModel> wijnen = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "W")
                {
                    wijnen.Add(menu[i]);
                }
            }

            return wijnen;
        }
        public List<MenuModel> GetGedestileerdeDranken()
        {
            List<MenuModel> gedestileerdeDranken = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "G")
                {
                    gedestileerdeDranken.Add(menu[i]);
                }
            }

            return gedestileerdeDranken;
        }
        public List<MenuModel> GetKoffieEnThee()
        {
            List<MenuModel> koffieEnThee = new List<MenuModel>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "K")
                {
                    koffieEnThee.Add(menu[i]);
                }
            }

            return koffieEnThee;
        }
    }
}
