using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
using DataAdaptor;

namespace Logica
{
    /*
     * Iedere functie in dit bestand haalt de menu items uit het menu
     * aan de hand van een code. Vervolgens worden die items in een list gezet.
     */
    public class Categoriseren_gerechten_logica {

        List<Menu> menu = Menu_DAO.GetMenuItems();
        
        public List<Menu> GetVoorgerechtenLunch()
        {
            List<Menu> voorgerechtenLunch = new List<Menu>();

            for(int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LV")
                {
                    voorgerechtenLunch.Add(menu[i]);
                }
            }

            return voorgerechtenLunch;
        }
        public List<Menu> GetHoofdgerechtenLunch()
        {
            List<Menu> hoofdgerechtenLunch = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LH")
                {
                    hoofdgerechtenLunch.Add(menu[i]);
                }
            }

            return hoofdgerechtenLunch;
        }
        public List<Menu> GetNagerechtenLunch()
        {
            List<Menu> nagerechtenLunch = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "LN")
                {
                    nagerechtenLunch.Add(menu[i]);
                }
            }

            return nagerechtenLunch;
        }
        public List<Menu> GetVoorgerechtenDiner()
        {
            List<Menu> voorgerechtenDiner = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DV")
                {
                    voorgerechtenDiner.Add(menu[i]);
                }
            }

            return voorgerechtenDiner;
        }
        public List<Menu> GetTussengerechtenDiner()
        {
            List<Menu> tussengerechtenDiner = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DT")
                {
                    tussengerechtenDiner.Add(menu[i]);
                }
            }

            return tussengerechtenDiner;
        }
        public List<Menu> GetHoofdgerechtenDiner()
        {
            List<Menu> hoofgerechtenDiner = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DH")
                {
                    hoofgerechtenDiner.Add(menu[i]);
                }
            }

            return hoofgerechtenDiner;
        }
        public List<Menu> GetNagerechtenDiner()
        {
            List<Menu> nagerechtenDiner = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "DN")
                {
                    nagerechtenDiner.Add(menu[i]);
                }
            }

            return nagerechtenDiner;
        }
        public List<Menu> GetFrisdranken()
        {
            List<Menu> frisdranken = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "F")
                {
                    frisdranken.Add(menu[i]);
                }
            }

            return frisdranken;
        }
        public List<Menu> GetBieren()
        {
            List<Menu> bieren = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "B")
                {
                    bieren.Add(menu[i]);
                }
            }

            return bieren;
        }
        public List<Menu> GetWijnen()
        {
            List<Menu> wijnen = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "W")
                {
                    wijnen.Add(menu[i]);
                }
            }

            return wijnen;
        }
        public List<Menu> GetGedestileerdeDranken()
        {
            List<Menu> gedestileerdeDranken = new List<Menu>();

            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].Categorie == "G")
                {
                    gedestileerdeDranken.Add(menu[i]);
                }
            }

            return gedestileerdeDranken;
        }
        public List<Menu> GetKoffieEnThee()
        {
            List<Menu> koffieEnThee = new List<Menu>();

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
