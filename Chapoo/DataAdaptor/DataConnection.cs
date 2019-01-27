using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public static class DataConnection
    {
        public static string connectionString = "Data Source=den1.mssql7.gear.host;Initial Catalog=chapoo1819f01;User ID=chapoo1819f01;Password=Pu0Q_utpxc-k";
        public static SqlConnection connection = new SqlConnection(connectionString);
    }
}
