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
    public class BestelOverzichtDAO
    {
        public static List<BestelOverzichtItemModel> GetNotificaties()
        {
            List<BestelOverzichtItemModel> notificaties = new List<BestelOverzichtItemModel>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM NOTIFICATIONS JOIN MENU ON menuId = menu_id ");

            while (data.Read())
            {
                int id = (int)data["id"];
                string item = (string)data["item"];
                int aantal = (int)data["amount"];
                string opmerking = (string)data["opmerkingen"];

                BestelOverzichtItemModel notificatie = new BestelOverzichtItemModel(id, item, aantal, opmerking);
                notificaties.Add(notificatie);
            }

            DataConnection.connection.Close();
            return notificaties;
        }
        public static List<BestelOverzichtItemModel> GetBarQueue()
        {
            List<BestelOverzichtItemModel> barQueue = new List<BestelOverzichtItemModel>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM GAAT_NAAR_BAR AS bar JOIN MENU AS menu ON bar.menu_id = menu.menu_id");

            while (data.Read())
            {
                int id = (int)data["bar_id"];
                string item = (string)data["item"];
                int aantal = (int)data["hoeveelheid"];
                string opmerking = (string)data["Commentaar"];

                BestelOverzichtItemModel notificatie = new BestelOverzichtItemModel(id, item, aantal, opmerking);
                barQueue.Add(notificatie);
            }

            DataConnection.connection.Close();
            return barQueue;
        }
        public static List<BestelOverzichtItemModel> GetKeukenQueue()
        {
            List<BestelOverzichtItemModel> keukenQueue = new List<BestelOverzichtItemModel>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM GAAT_NAAR_KEUKEN AS keuken JOIN MENU AS menu ON keuken.menu_id = menu.menu_id");

            while (data.Read())
            {
                int id = (int)data["keuken_id"];
                string item = (string)data["item"];
                int aantal = (int)data["hoeveelheid"];
                string opmerking = (string)data["Commentaar"];

                BestelOverzichtItemModel notificatie = new BestelOverzichtItemModel(id, item, aantal, opmerking);
                keukenQueue.Add(notificatie);
            }

            DataConnection.connection.Close();
            return keukenQueue;
        }
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
        public void DeleteAllInBarQueue(int id)
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
        public void DeleteAllInKeukenQueue(int id)
        {
            SqlConnection connection = DataConnection.connection;
            StringBuilder sb = new StringBuilder();

            connection.Open();

            sb.Append("DELETE FROM GAAT_NAAR_KEUKEN WHERE keuken_id = @keuken_id");

            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@keuken_id", id);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
