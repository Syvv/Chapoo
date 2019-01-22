using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAdaptor
{
    public class OrderViewDAO
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
        public void ChangeInKeukenQueue(int id, int aantal, string comment)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            sb.Append("UPDATE GAAT_NAAR_KEUKEN SET Commentaar = @comment, hoeveelheid = @aantal WHERE keuken_id = @keukenId");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@keukenId", id);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@aantal", aantal);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
        public void ChangeInBarQueue(int id, int aantal, string comment)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            sb.Append("UPDATE GAAT_NAAR_BAR SET Commentaar = @comment, hoeveelheid = @aantal WHERE bar_id = @barId");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@barId", id);
                cmd.Parameters.AddWithValue("@comment", comment);
                cmd.Parameters.AddWithValue("@aantal", aantal);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}