using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class BestellingsItemLogica
    {
        private BestellingsItemDAO DAO = new BestellingsItemDAO();
        private Model.Werknemer werknemer;

        public BestellingsItemLogica(Model.Werknemer werknemer)
        {
            this.werknemer = werknemer;
        }

        public List<Bestellingsitem> GetBestellingsitems()
        {
            if(werknemer.Functie==FunctieType.Bar)
            {
                return DAO.HaalBarItemsOp();
            }
            return DAO.HaalKeukenItemsOp();
        }

    }
}
