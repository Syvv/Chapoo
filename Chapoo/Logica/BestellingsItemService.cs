﻿using System;
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
        private BestellingsItemDAO DAO;
        private WerknemerModel werknemer;
        private DAOFactory factory;

        public BestellingsItemService(WerknemerModel werknemer, DAOFactory factory)
        {
            this.werknemer = werknemer;
            this.factory = factory;
            DAO = factory.CreateBestellingsItemDAO();
        }

        public List<BestellingsitemModel> GetBestellingsitems()
        {
            if(werknemer.Functie==Functie.Bar)
            {
                return DAO.HaalBarItemsOp();
            }
            return DAO.HaalKeukenItemsOp();
        }

        public void StelBestellingsItemGereed(BestellingsitemModel item)
        {
            DAO.StelBestellingsItemGereed(item);
        }
        public bool InsertBestellingItems(List<BestellingsitemModel> bestellingsitems)
        {
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
