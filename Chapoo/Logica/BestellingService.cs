using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class BestellingService 
    {
        public int InsertBestelling(BestellingModel bestelling, DAOFactory factory)
        {
            BestellingDAO BestellingDAO = factory.CreateBestellingDAO();
            //Geeft nieuwe bestellingId terug
            return BestellingDAO.InsertBestelling(bestelling);
        }
        public bool CheckVoorOpenstaandeBestelling(int bestellingId, DAOFactory factory)
        {
            BestellingDAO BestellingDAO = factory.CreateBestellingDAO();
            //Geeft terug of de bestelling openstaat of niet
            return BestellingDAO.CheckVoorOpenstaandeBestelling(bestellingId);
        }
        public int GetLaatseBestelling(int tafelId, DAOFactory factory)
        {
            BestellingDAO BestellingDAO = factory.CreateBestellingDAO();
            //Geeft laatste bestelling terug
            return BestellingDAO.GetLaatsteBestelling(tafelId);
        }
    }
}
