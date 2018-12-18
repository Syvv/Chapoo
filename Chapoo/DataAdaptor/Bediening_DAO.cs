using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    class Bediening_DAO
    {
        public static List<string> GetFris()
        {
            List<string> result = new List<string>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM MENU WHERE categorie = 'N'");

            while (data.Read())
            {
                result.Add(data.GetFieldValue<int>(0) + " - " + data.GetFieldValue<string>(1));
            }
            return result;
        }
    }
}
