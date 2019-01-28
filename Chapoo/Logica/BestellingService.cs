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
        private BestellingDAO BestellingDAO { get; set; }
        private int BestellingId { get; set; }
        public int InsertBestelling(BestellingModel bestelling)
        {
            BestellingDAO = new BestellingDAO();
            //Geeft nieuwe bestellingId terug
            return BestellingDAO.InsertBestelling(bestelling);
        }
        public bool CheckVoorOpenstaandeBestelling(int bestellingId)
        {
            BestellingDAO = new BestellingDAO();
            //Geeft terug of de bestelling openstaat of niet
            return BestellingDAO.CheckVoorOpenstaandeBestelling(bestellingId);
        }
        public int GetLaatseBestelling(TafelModel tafel)
        {
            BestellingDAO = new BestellingDAO();
            //Geeft laatste bestelling terug
            return BestellingDAO.GetLaatsteBestelling(tafel);
        }
      /*  public int ReturnOrInsert(bool bestellingOpen, TafelModel tafel)
        {
            BestellingDAO = new BestellingDAO();
            if (bestellingOpen)
            {
                this.BestellingId = 
            }
            else
            {

            }
        }*/
    }
}
