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
   public class MenuItem_DAO
   {
        public int InsertMenuItem(int tafelId, int werknemerId)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            int bestellingId = 0;

            sb.Append("INSERT INTO BESTELLING (tafel_id, werknemer_id) VALUES(@tafeld, @werknemerId); SELECT SCOPE_IDENTITY()");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@tafeld", tafelId);
                cmd.Parameters.AddWithValue("@werknemerId", werknemerId);
                bestellingId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();
            }              

            connection.Close();
            return bestellingId;
        }
        public void InsertInKeukenqueue(List<Queue_item> list)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            foreach (Queue_item item in list)
            {
                int bestellingId = item.BestellingId;
                int menuId = item.MenuId;
                int hoeveelheid = item.Aantal;
                string commentaar = item.Comment;

                sb.Append("INSERT INTO GAAT_NAAR_KEUKEN (bestelling_id, menu_id, hoeveelheid, Commentaar ) VALUES(@bestellingId, @menuId, @hoeveelheid, @commentaar)");

                String sql = sb.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@bestellingId", bestellingId);
                    cmd.Parameters.AddWithValue("@menuId", menuId);
                    cmd.Parameters.AddWithValue("@hoeveelheid", hoeveelheid);
                    cmd.Parameters.AddWithValue("@commentaar", commentaar);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
        public void InsertInBarqueue(List<Queue_item> list)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            foreach (Queue_item item in list)
            {
                int bestellingId = item.BestellingId;
                int menuId = item.MenuId;
                int hoeveelheid = item.Aantal;
                string commentaar = item.Comment;

                sb.Append("INSERT INTO GAAT_NAAR_BAR (bestelling_id, menu_id, hoeveelheid, Commentaar ) VALUES(@bestellingId, @menuId, @hoeveelheid, @commentaar)");

                String sql = sb.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@bestellingId", bestellingId);
                    cmd.Parameters.AddWithValue("@menuId", menuId);
                    cmd.Parameters.AddWithValue("@hoeveelheid", hoeveelheid);
                    cmd.Parameters.AddWithValue("@commentaar", commentaar);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }
    }
}
