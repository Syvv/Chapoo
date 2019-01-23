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
   public class BestellingOpnemenDAO
   {
        public int InsertMenuItem(int tafelId, int werknemerId)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            int bestellingId = 0;

            sb.Append("INSERT INTO BESTELLING (tafel_id, werknemer_id) VALUES(@tafeld, @werknemerId); SELECT SCOPE_IDENTITY();");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@tafeld", tafelId);
                cmd.Parameters.AddWithValue("@werknemerId", werknemerId);
                bestellingId = Convert.ToInt32(cmd.ExecuteScalar());
            }              

            connection.Close();
            return bestellingId;
        }
        public void InsertInKeukenqueue(List<QueueItemModel> list)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            foreach (QueueItemModel item in list)
            {
                int bestellingId = item.BestellingId;
                int menuId = item.MenuId;
                int hoeveelheid = item.Aantal;
                string commentaar = item.Comment;
                DateTime timestamp = item.Timestamp;

                sb.Append("INSERT INTO GAAT_NAAR_KEUKEN (bestelling_id, menu_id, hoeveelheid, Commentaar, timestamp ) VALUES(@bestellingId, @menuId, @hoeveelheid, @commentaar, @timestamp);");

                String sql = sb.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@bestellingId", bestellingId);
                    cmd.Parameters.AddWithValue("@menuId", menuId);
                    cmd.Parameters.AddWithValue("@hoeveelheid", hoeveelheid);
                    cmd.Parameters.AddWithValue("@commentaar", commentaar);
                    cmd.Parameters.AddWithValue("@timestamp", timestamp);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
        public void InsertInBarqueue(List<QueueItemModel> list)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            foreach (QueueItemModel item in list)
            {
                int bestellingId = item.BestellingId;
                int menuId = item.MenuId;
                int hoeveelheid = item.Aantal;
                string commentaar = item.Comment;
                DateTime timestamp = item.Timestamp;

                sb.Append("INSERT INTO GAAT_NAAR_BAR (bestelling_id, menu_id, hoeveelheid, Commentaar, timestamp ) VALUES(@bestellingId, @menuId, @hoeveelheid, @commentaar, @timestamp);");

                String sql = sb.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@bestellingId", bestellingId);
                    cmd.Parameters.AddWithValue("@menuId", menuId);
                    cmd.Parameters.AddWithValue("@hoeveelheid", hoeveelheid);
                    cmd.Parameters.AddWithValue("@commentaar", commentaar);
                    cmd.Parameters.AddWithValue("@timestamp", timestamp);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
        public void InsertInHeeftItem(List<HeeftItemModel> list)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            foreach (HeeftItemModel item in list)
            {
                int bestellingId = item.BestellingId;
                int menuId = item.MenuId;
                int hoeveelheid = item.Aantal;

                sb.Append("INSERT INTO HEEFT_ITEM (bestel_id, menu_id, amount, btw) VALUES(@bestellingId, @menuId, @hoeveelheid, @btw)");

                String sql = sb.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@bestellingId", bestellingId);
                    cmd.Parameters.AddWithValue("@menuId", menuId);
                    cmd.Parameters.AddWithValue("@hoeveelheid", hoeveelheid);
                    cmd.Parameters.AddWithValue("@btw", 9);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
    }
}
