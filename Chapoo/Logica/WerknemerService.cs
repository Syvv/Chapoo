using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class Werknemer
    {
        [Obsolete("Don't use a non empty constructor")]
        public Werknemer(DAOFactory factory)
        {
        }

        public Model.WerknemerModel CheckInlogGegevens(string gebruikersnaam, string wachtwoord, DAOFactory factory)
        {
            WerknemerDAO DAO = factory.CreateWerknemerDAO();
            return DAO.CheckLogin(gebruikersnaam, wachtwoord);
        }

    }
}
