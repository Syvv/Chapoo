using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public static class KeukenBarDataConnection
    {
        
        public static SqlDataReader GetOpenOrdersBar()
        {
            SqlDataReader data;

            data = DataConnection.Query(
                "SELECT b.tafel_id, m.item, gb.hoeveelheid, gb.Commentaar, gb.bar_id, m.menu_id, gb.timestamp  FROM GAAT_NAAR_BAR gb " +
                "INNER JOIN BESTELLING b ON gb.bestelling_id = b.bestelling_id " +
                "INNER JOIN MENU m ON m.menu_id = gb.menu_id; "
            );
            return data;
        }

        public static SqlDataReader GetOpenOrdersKeuken()
        {
            SqlDataReader data;

            data = DataConnection.Query(
                "SELECT b.tafel_id, m.item, gk.hoeveelheid, gk.Commentaar, gk.keuken_id, m.menu_id, gk.timestamp  FROM GAAT_NAAR_KEUKEN gk " +
                "INNER JOIN BESTELLING b ON gk.bestelling_id = b.bestelling_id " +
                "INNER JOIN MENU m ON m.menu_id = gk.menu_id; "
            );
            return data;
        }

        public static void RemoveOpenItemKeuken(int id)
        {
            DataConnection.ClosedQuery(
                "DELETE FROM GAAT_NAAR_KEUKEN " +
                "WHERE keuken_id = " + id+ ";"
                );
        }

        public static void RemoveOpenItemBar(int id)
        {
            DataConnection.ClosedQuery(
                "DELETE FROM GAAT_NAAR_BAR " +
                "WHERE bar_id = " + id + ";"
                );
        }

        public static void CreateNotification(Model.Bestellingsitem[] list)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Model.Bestellingsitem b in list)
            {
                sb.Append("INSERT INTO NOTIFICATIONS VALUES("+b.Tafel+","+b.MenuId+","+b.OriginalAmount+",'"+b.Comment+"');");
            }
            DataConnection.ClosedQuery(sb.ToString());
        }
        
        public static void UpdateAmountKeuken(Model.Bestellingsitem item)
        {
            DataConnection.ClosedQuery(
                "UPDATE GAAT_NAAR_KEUKEN " +
                "SET hoeveelheid = "+item.Amount+" " +
                "WHERE keuken_id = "+item.Id+";"
                );
        }

        public static void UpdateAmountBar(Model.Bestellingsitem item)
        {
            DataConnection.ClosedQuery(
                "UPDATE GAAT_NAAR_BAR " +
                "SET hoeveelheid = " + item.Amount + " " +
                "WHERE bar_id = " + item.Id + ";"
                );
        }
    }
}
