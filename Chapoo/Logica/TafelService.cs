using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class TafelService
    {
        private TafelDAO TafelDao;
        private DAOFactory Factory;

        public TafelService(DAOFactory factory)
        {
            Factory = factory;
            TafelDao = factory.CreateTafelDAO();
        }

        public TafelModel TafelVuller(int tafelnummer)
        {
            TafelModel tafel = TafelDao.TafelInfoVuller(tafelnummer);
            return tafel;
        }
    }
}
