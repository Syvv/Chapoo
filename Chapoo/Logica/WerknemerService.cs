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
        private DAOFactory factory;

        public Werknemer(DAOFactory factory)
        {
            this.factory = factory;
            DAO = factory.CreateWerknemerDAO();
        }

        public Model.WerknemerModel CheckInlogGegevens(string gebruikersnaam, string wachtwoord)
        {
            return DAO.CheckLogin(gebruikersnaam, wachtwoord);
        }

    }
}
