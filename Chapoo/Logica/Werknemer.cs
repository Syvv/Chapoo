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
        private WerknemerDAO DAO;

        public Werknemer()
        {
            DAO = new WerknemerDAO();
        }

        public Model.Werknemer CheckInlogGegevens(string gebruikersnaam, string wachtwoord)
        {
            return DAO.CheckLogin(gebruikersnaam, wachtwoord);
        }

    }
}
