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
            if (werknemer.Functie == Functie.Bar)
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

        public List<BestellingsitemModel> GetAlleBestellingenVanVandaag(WerknemerModel werknemer, DAOFactory factory)
        {
            BestellingsItemDAO DAO = factory.CreateBestellingsItemDAO();
            //Maak huidige tijd aan
            DateTime now = DateTime.Now;
            DateTime vanochtend = new DateTime(now.Year,now.Month,now.Day);

            if(werknemer.Functie==Functie.Bar)
            {
                return DAO.HaalBarBestellingsitemsVandaagOp(vanochtend);
            }
            else
            {
                return DAO.HaalKeukenBestellingsitemsVandaagOp(vanochtend);
            }
        }

    }
}
