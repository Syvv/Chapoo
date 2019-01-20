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
    public class Bestel_overzicht_DAO
    {
        public static List<Notificatie> GetNotificaties()
        {
            List<Notificatie> notificaties = new List<Notificatie>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM NOTIFICATIONS JOIN MENU ON menuId = menu_id ");

            while (data.Read())
            {
                int id = (int)data["id"];
                string item = (string)data["item"];
                int aantal = (int)data["amount"];
                string opmerking = (string)data["opmerkingen"];

                Notificatie notificatie = new Notificatie(id, item, aantal, opmerking);
                notificaties.Add(notificatie);
            }

            DataConnection.connection.Close();
            return notificaties;
        }
        public static List<Notificatie> GetBarQueue()
        {
            List<Notificatie> barQueue = new List<Notificatie>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM GAAT_NAAR_BAR AS bar JOIN MENU AS menu ON bar.menu_id = menu.menu_id");

            while (data.Read())
            {
                int id = (int)data["bar_id"];
                string item = (string)data["item"];
                int aantal = (int)data["hoeveelheid"];
                string opmerking = (string)data["Commentaar"];

                Notificatie notificatie = new Notificatie(id, item, aantal, opmerking);
                barQueue.Add(notificatie);
            }

            DataConnection.connection.Close();
            return barQueue;
        }
        public static List<Notificatie> GetKeukenQueue()
        {
            List<Notificatie> keukenQueue = new List<Notificatie>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM GAAT_NAAR_KEUKEN AS keuken JOIN MENU AS menu ON keuken.menu_id = menu.menu_id");

            while (data.Read())
            {
                int id = (int)data["keuken_id"];
                string item = (string)data["item"];
                int aantal = (int)data["hoeveelheid"];
                string opmerking = (string)data["Commentaar"];

                Notificatie notificatie = new Notificatie(id, item, aantal, opmerking);
                keukenQueue.Add(notificatie);
            }

            DataConnection.connection.Close();
            return keukenQueue;
        }
    }
}
