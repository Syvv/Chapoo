using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAdaptor
{
    public class Order_view_DAO
    {
        public void DeleteFromBarQueue(int id)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            sb.Append("DELETE FROM GAAT_NAAR_BAR WHERE bar_id = @barId");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@barId", id);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        public void DeleteFromKeukenQueue(int id)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            sb.Append("DELETE FROM GAAT_NAAR_KEUKEN WHERE keuken_id = @keukenId");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@keukenId", id);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}