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
        public int InsertBestelling(Bestelling bestelling)
        {
            BestellingDAO = new BestellingDAO();
            return BestellingDAO.InsertBestelling(bestelling);
        }
    }
}
