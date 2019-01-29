using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class BestellingsItemService
    {

        public List<BestellingsitemModel> GetBestellingsitems(WerknemerModel werknemer, DAOFactory factory)
        {
            BestellingsItemDAO DAO = factory.CreateBestellingsItemDAO();
            if(werknemer.Functie==Functie.Bar)
            {
                return DAO.HaalBarItemsOp();
            }
            return DAO.HaalKeukenItemsOp();
        }

        public void StelBestellingsItemGereed(BestellingsitemModel item, DAOFactory factory)
        {
            BestellingsItemDAO DAO = factory.CreateBestellingsItemDAO();
            DAO.StelBestellingsItemGereed(item);
        }
        public bool InsertBestellingItems(List<BestellingsitemModel> bestellingsitems, DAOFactory factory)
        {
            BestellingsItemDAO DAO = factory.CreateBestellingsItemDAO();
            try
            {
                DAO.InsertBestellingItems(bestellingsitems);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
