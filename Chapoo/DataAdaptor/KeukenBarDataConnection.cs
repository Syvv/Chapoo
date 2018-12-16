using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public static class KeukenBarDataConnection
    {
        
        public static List<string> GetOpenOrders(bool isBar)
        {
            List<string> result = new List<string>();
            SqlDataReader data;
            if(isBar)
            {
                data = DataConnection.Query("SELECT * FROM BARQUEUE");//temp weet ff niet hoe de kolommen heten
            }
            else
            {
                data = DataConnection.Query("SELECT * FROM KEUKENQUEUE");//temp weet ff niet hoe de kolommen heten
            }

            while(data.Read())
            {
                result.Add(data.GetFieldValue<int>(0) +  " - " + data.GetFieldValue<string>(1));
            }
            return result;
        }
    }
}
