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

        List<MenuItem> menu = MenuDAO.GetMenuItems();
        
        public List<MenuItem> GetVoorgerechtenLunch()
        {
            List<MenuItem> voorgerechtenLunch = new List<MenuItem>();

            for(int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LV")
                {
                    voorgerechtenLunch.Add(menu[i]);
                }
            }

            return voorgerechtenLunch;
        }
        public List<MenuItem> GetHoofdgerechtenLunch()
        {
            List<MenuItem> hoofdgerechtenLunch = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LH")
                {
                    hoofdgerechtenLunch.Add(menu[i]);
                }
            }

            return hoofdgerechtenLunch;
        }
        public List<MenuItem> GetNagerechtenLunch()
        {
            List<MenuItem> nagerechtenLunch = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LN")
                {
                    nagerechtenLunch.Add(menu[i]);
                }
            }

            return nagerechtenLunch;
        }
        public List<MenuItem> GetVoorgerechtenDiner()
        {
            List<MenuItem> voorgerechtenDiner = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DV")
                {
                    voorgerechtenDiner.Add(menu[i]);
                }
            }

            return voorgerechtenDiner;
        }
        public List<MenuItem> GetTussengerechtenDiner()
        {
            List<MenuItem> tussengerechtenDiner = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DT")
                {
                    tussengerechtenDiner.Add(menu[i]);
                }
            }

            return tussengerechtenDiner;
        }
        public List<MenuItem> GetHoofdgerechtenDiner()
        {
            List<MenuItem> hoofgerechtenDiner = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DH")
                {
                    hoofgerechtenDiner.Add(menu[i]);
                }
            }

            return hoofgerechtenDiner;
        }
        public List<MenuItem> GetNagerechtenDiner()
        {
            List<MenuItem> nagerechtenDiner = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DN")
                {
                    nagerechtenDiner.Add(menu[i]);
                }
            }

            return nagerechtenDiner;
        }
        public List<MenuItem> GetFrisdranken()
        {
            List<MenuItem> frisdranken = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "F")
                {
                    frisdranken.Add(menu[i]);
                }
            }

            return frisdranken;
        }
        public List<MenuItem> GetBieren()
        {
            List<MenuItem> bieren = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "B")
                {
                    bieren.Add(menu[i]);
                }
            }

            return bieren;
        }
        public List<MenuItem> GetWijnen()
        {
            List<MenuItem> wijnen = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "W")
                {
                    wijnen.Add(menu[i]);
                }
            }

            return wijnen;
        }
        public List<MenuItem> GetGedestileerdeDranken()
        {
            List<MenuItem> gedestileerdeDranken = new List<MenuItem>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "G")
                {
                    gedestileerdeDranken.Add(menu[i]);
                }
            }

            return gedestileerdeDranken;
        }
        public List<MenuItem> GetKoffieEnThee()
        {
            List<MenuItem> koffieEnThee = new List<MenuItem>();

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
