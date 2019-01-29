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

        public List<BestellingsitemModel> GetBestellingsitems(WerknemerModel werknemer)
        {
            BestellingsItemDAO DAO = DAOFactory.Instance.CreateBestellingsItemDAO();
            if (werknemer.Functie == Functie.Bar)
            {
                return DAO.HaalBarItemsOp();
            }
            return DAO.HaalKeukenItemsOp();
        }

        public void StelBestellingsItemGereed(BestellingsitemModel item)
        {
            BestellingsItemDAO DAO = DAOFactory.Instance.CreateBestellingsItemDAO();
            DAO.StelBestellingsItemGereed(item);
        }
        public bool InsertBestellingItems(List<BestellingsitemModel> bestellingsitems)
        {
            BestellingsItemDAO DAO = DAOFactory.Instance.CreateBestellingsItemDAO();

                DAO.InsertBestellingItems(bestellingsitems);

            return true;
        }

        public List<BestellingsitemModel> GetAlleBestellingenVanVandaag(WerknemerModel werknemer)
        {
            BestellingsItemDAO DAO = DAOFactory.Instance.CreateBestellingsItemDAO();
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
