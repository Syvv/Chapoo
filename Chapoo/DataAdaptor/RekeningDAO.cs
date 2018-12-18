using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAdaptor
{
    public class RekeningDAO
    {
        public static void ZetTafelVrijmaken(int tafelId)
        {
            string query = "update TAFEL set Bezet = 0 where id = '@_tafelid";
            query = query.Replace("@_tafelid", tafelId.ToString());

            SqlDataReader update;
            update = DataConnection.Query(query);
        }
    }
}
