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

        public TafelModel TafelVuller(int tafelnummer)
        {
            TafelModel tafel = DAOFactory.Instance.CreateTafelDAO().TafelInfoVuller(tafelnummer);
            return tafel;
        }
    }
}
