using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public class UserConnection
    {

        public static SqlDataReader CheckLogin(string user, string pass)
        {
            SqlDataReader data;
            data = DataConnection.Query(
                "SELECT inlog_naam, functie " +
                "FROM WERKNEMER " +
                "WHERE inlog_naam = '"+user+"' AND wachtwoord = '"+pass+"';"
            );
            return data;
        }

    }
}
