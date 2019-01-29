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
        public int InsertBestelling(BestellingModel bestelling)
        {
            StringBuilder sb = new StringBuilder();

            connection.Open();

            int tafelId = bestelling.Tafel.Id;
            int werknemerId = bestelling.Werknemer.Id;
            int bestellingId = 0;

            sb.Append("INSERT INTO BESTELLING (tafelId, werknemerId) VALUES(@tafelId, @werknemerId); SELECT SCOPE_IDENTITY();");

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
        public bool CheckVoorOpenstaandeBestelling(int bestellingId)
        {
            bool bestellingStaatOpen = false;
            StringBuilder sb = new StringBuilder();
            SqlDataReader data;

            connection.Open();

            sb.Append("SELECT bestellingId FROM REKENING WHERE bestellingId = @bestellingId");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@bestellingId", bestellingId);
                data = cmd.ExecuteReader();
            }
            
            if (!data.HasRows)
                bestellingStaatOpen = true;

            connection.Close();

            return bestellingStaatOpen;
        }
        public int GetLaatsteBestelling(int tafelId)
        {
            int bestellingId = 0;

            StringBuilder sb = new StringBuilder();

            connection.Open();
            sb.Append("SELECT bestellingId FROM BESTELLING WHERE tafelId = @tafelId ORDER BY bestellingId DESC");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@tafelId", tafelId);

            SqlDataReader data = command.ExecuteReader();


            while (data.Read())
            {
                bestellingId =  (int)data["bestellingId"];
            }

            connection.Close();

            return bestellingId;
        }
    }
}
