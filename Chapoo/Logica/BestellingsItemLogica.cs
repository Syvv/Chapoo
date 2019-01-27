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
        private BestellingsItemDAO DAO;
        private Model.Werknemer werknemer;
        private DAOFactory factory;

        public BestellingsItemLogica(Model.Werknemer werknemer, DAOFactory factory)
        {
            this.werknemer = werknemer;
            this.factory = factory;
            DAO = factory.CreateBestellingsItemDAO();
        }

        public List<Bestellingsitem> GetBestellingsitems()
        {
            if(werknemer.Functie==Functie.Bar)
            {
                return DAO.HaalBarItemsOp();
            }
            return DAO.HaalKeukenItemsOp();
        }

    }
}
