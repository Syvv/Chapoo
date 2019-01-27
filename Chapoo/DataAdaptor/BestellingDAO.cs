using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Model;

namespace DataAdaptor
{
    public class BestellingDAO
    {
        private SqlConnection connection = DataConnection.connection;
        public int InsertBestelling(Bestelling bestelling)
        {
            StringBuilder sb = new StringBuilder();

            connection.Open();

            int tafelId = bestelling.Tafel.Id;
            int werknemerId = bestelling.Werknemer.Id;
            int bestellingId = 0;

            sb.Append("INSERT INTO BESTELLING (tafel-id, werknemer-id) VALUES(@tafelId, @werknemerId); SELECT SCOPE_IDENTITY();");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@tafelId", tafelId);
                cmd.Parameters.AddWithValue("@werknemerId", werknemerId);
                bestellingId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            connection.Close();
            return bestellingId;
        }
    }
}
