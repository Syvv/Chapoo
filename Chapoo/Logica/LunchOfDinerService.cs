using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DataAdaptor;

namespace Logica
{
    public class LunchOfDinerService
    {
        private List<MenuModel> List = new List<MenuModel>();
        private CategoriserenGerechtenService Gerechten = new CategoriserenGerechtenService();

        public List<MenuModel> Voorgerecht()
        {
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = new TimeSpan(17, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
               List = Gerechten.GetVoorgerechtenLunch();
            }
            else
            {
               List = Gerechten.GetVoorgerechtenDiner();
            }

            return List;
        }
        public List<MenuModel> Hoofdgerechten()
        {
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = new TimeSpan(17, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                List = Gerechten.GetHoofdgerechtenLunch();
            }
            else
            {
                List = Gerechten.GetHoofdgerechtenDiner();
            }

            return List;
        }
        public List<MenuModel> Nagerechten()
        {
            TimeSpan start = new TimeSpan(10, 0, 0);
            TimeSpan end = new TimeSpan(17, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                List = Gerechten.GetNagerechtenLunch();
            }
            else
            {
                List = Gerechten.GetNagerechtenDiner();
            }

            return List;
        }
    }
}
