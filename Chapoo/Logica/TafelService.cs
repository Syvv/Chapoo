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
        [Obsolete("Don't use a non empty constructor")]
        public TafelService(DAOFactory factory)
        {
        }

        public TafelModel TafelVuller(int tafelnummer, DAOFactory factory)
        {
            TafelModel tafel = factory.CreateTafelDAO().TafelInfoVuller(tafelnummer);
            return tafel;
        }
    }
}
