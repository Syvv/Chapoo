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
    public class Lunch_of_Diner_Logica
    {
        protected List<Model.Menu> List = new List<Model.Menu>();
        protected Categoriseren_gerechten_logica Gerechten = new Categoriseren_gerechten_logica();

        public List<Model.Menu> Voorgerecht()
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
        public List<Model.Menu> Hoofdgerechten()
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
        public List<Model.Menu> Nagerechten()
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
