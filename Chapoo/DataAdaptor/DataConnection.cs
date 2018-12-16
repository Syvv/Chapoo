using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public class DataConnection
    {

        protected string connectionString = "Data Source=den1.mssql7.gear.host;Initial Catalog=chapoo1819f01;User ID=chapoo1819f01;Password=Pu0Q_utpxc-k";
        protected SqlConnection connection;

        public DataConnection()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlDataReader Query(string query)
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand(query, connection);
                return sql.ExecuteReader();
            }
            finally
            {
                connection.Close();
            }
            
        }


    }
}
