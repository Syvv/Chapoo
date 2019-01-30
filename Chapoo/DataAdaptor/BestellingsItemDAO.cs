using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAdaptor
{
    public class BestellingsItemDAO
    {
        private SqlConnection connection;

        public BestellingsItemDAO(SqlConnection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }
        public void InsertBestellingItems(List<BestellingsitemModel> bestellingsitems)
        {
            StringBuilder sb = new StringBuilder();

            connection.Open();


            sb.Append("INSERT INTO HEEFT_ITEM (menuId, bestellingId, timestamp, hoeveelheid, commentaar, status) " +
            "VALUES(@menuId, @bestellingId, @timestamp, @hoeveelheid, @commentaar, 'besteld');" +
            "UPDATE MENU SET voorraad -= @hoeveelheid WHERE menu_id = @menuId;");

            String sql = sb.ToString();

            foreach (BestellingsitemModel bestellingsitem in bestellingsitems)
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@menuId", bestellingsitem.MenuId);
                    cmd.Parameters.AddWithValue("@bestellingId", bestellingsitem.BestellingsId);
                    cmd.Parameters.AddWithValue("@timestamp", bestellingsitem.Timestamp);
                    cmd.Parameters.AddWithValue("@hoeveelheid", bestellingsitem.Hoeveelheid);
                    cmd.Parameters.AddWithValue("@commentaar", bestellingsitem.Commentaar);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public List<BestellingsitemModel> HaalBarItemsOp()
        {
            return HaalVoorwaardelijkItemsOp("WHERE (m.categorie = 'F' OR m.categorie = 'B' OR m.categorie = 'W' OR m.categorie = 'G' OR m.categorie = 'K') AND status = 'besteld'");
        }

        public List<BestellingsitemModel> HaalKeukenItemsOp()
        {
            return HaalVoorwaardelijkItemsOp("WHERE (m.categorie = 'LV' OR m.categorie = 'LH' OR m.categorie = 'LN' OR m.categorie = 'DV' OR m.categorie = 'DT' OR m.categorie = 'DH' " +
                        "OR m.categorie = 'DN') AND status = 'besteld'");
        }

        public List<BestellingsitemModel> HaalBarBestellingsitemsVandaagOp(DateTime ochtendTijd)
        {
            return HaalBestellingsitemsVandaagOp(ochtendTijd, " AND (m.categorie = 'F' OR m.categorie = 'B' OR m.categorie = 'W' OR m.categorie = 'G' OR m.categorie = 'K');");
        }

        public List<BestellingsitemModel> HaalKeukenBestellingsitemsVandaagOp(DateTime ochtendTijd)
        {
            return HaalBestellingsitemsVandaagOp(ochtendTijd, " AND (m.categorie = 'LV' OR m.categorie = 'LH' OR m.categorie = 'LN' OR m.categorie = 'DV' OR m.categorie = 'DT' OR m.categorie = 'DH' " +
                        "OR m.categorie = 'DN');");
        }

        private List<BestellingsitemModel> HaalBestellingsitemsVandaagOp(DateTime ochtendTijd, string queryToAdd)
        {
            List<BestellingsitemModel> result = new List<BestellingsitemModel>();
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, h.commentaar, h.hoeveelheid, b.tafelId, m.menu_id, h.timestamp, m.prijs, m.categorie, h.bestellingId, m.btw, h.status " +
                        "FROM HEEFT_ITEM h " +
                        "INNER JOIN MENU m ON h.menuId = m.menu_id " +
                        "INNER JOIN BESTELLING b ON b.bestellingId = h.bestellingId " +
                        "WHERE (h.timestamp BETWEEN @ochtend AND @nacht)");
            sb.Append(queryToAdd);

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            SqlParameter ochtend = new SqlParameter("@ochtend", System.Data.SqlDbType.DateTime) { Value = ochtendTijd};
            SqlParameter nacht = new SqlParameter("@nacht", System.Data.SqlDbType.DateTime) { Value = ochtendTijd.AddDays(1) };
            command.Parameters.Add(ochtend);
            command.Parameters.Add(nacht);

            SqlDataReader data = command.ExecuteReader();
            //lees alle waardes uit
            while (data.Read())
            {
                result.Add(LeesBestellingsItemMetStatus(data));
            }
            connection.Close();
            return result;
        }

        private List<BestellingsitemModel> HaalVoorwaardelijkItemsOp(string voorwaarde)//string voorwaarde is een deel van een query die bepaald welke items de query moet selecteren
        {
            List<BestellingsitemModel> result = new List<BestellingsitemModel>();
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, h.commentaar, h.hoeveelheid, b.tafelId, m.menu_id, h.timestamp, m.prijs, m.categorie, h.bestellingId, m.btw " +
                        "FROM HEEFT_ITEM h " +
                        "INNER JOIN MENU m ON h.menuId = m.menu_id " +
                        "INNER JOIN BESTELLING b ON b.bestellingId = h.bestellingId ");
            sb.Append(voorwaarde);

            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            SqlDataReader data = command.ExecuteReader();
            //lees alle waardes uit
            while (data.Read())
            {
                result.Add(LeesBestellingsItem(data));
            }
            connection.Close();
            return result;
        }

        public List<BestellingsitemModel> HaalAlleItemsOp(int bestellingsId)
        {
            List<BestellingsitemModel> result = new List<BestellingsitemModel>();
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, h.commentaar, h.hoeveelheid, b.tafelId, m.menu_id, h.timestamp, m.prijs, m.categorie, h.bestellingId, m.btw " +
                        "FROM HEEFT_ITEM h " +
                        "INNER JOIN MENU m ON h.menuId = m.menu_id " +
                        "INNER JOIN BESTELLING b ON b.bestellingId = h.bestellingId " +
                        "WHERE h.bestellingId = @bestellingsId");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@bestellingsId",bestellingsId);

            SqlDataReader data = command.ExecuteReader();
            //lees alle waardes uit
            while (data.Read())
            {
                result.Add(LeesBestellingsItem(data));
            }
            connection.Close();
            return result;
        }

        public void StelBestellingsItemGereed(BestellingsitemModel item)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("UPDATE HEEFT_ITEM " +
                "SET status = 'gereed' " +
                "WHERE bestellingId = @bestellingId AND menuId = @menuId AND timestamp = @timestamp");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            SqlParameter bestellingId = new SqlParameter("@bestellingId", System.Data.SqlDbType.Int){ Value = item.BestellingsId};
            SqlParameter menuId = new SqlParameter("@menuId", System.Data.SqlDbType.Int) { Value = item.MenuId };
            SqlParameter timestamp = new SqlParameter("@timestamp", System.Data.SqlDbType.DateTime) { Value = item.Timestamp };
            command.Parameters.Add(bestellingId);
            command.Parameters.Add(menuId);
            command.Parameters.Add(timestamp);

            command.ExecuteNonQuery();
            connection.Close();
        }

        private BestellingsitemModel LeesBestellingsItem(SqlDataReader data)
        {
            string naam = data.GetFieldValue<string>(0);
            string commentaar = data.GetFieldValue<string>(1);
            int hoeveelheid = data.GetFieldValue<int>(2);
            int tafelId = data.GetFieldValue<int>(3);
            int id = data.GetFieldValue<int>(4);
            DateTime timestamp = data.GetFieldValue<DateTime>(5);
            double prijs = data.GetFieldValue<double>(6);
            Categorie categorie;
            switch (data.GetFieldValue<string>(7))
            {
                case "F":
                    categorie = Categorie.Frisdrank;
                    break;
                case "B":
                    categorie = Categorie.Bier;
                    break;
                case "W":
                    categorie = Categorie.Wijn;
                    break;
                case "G":
                    categorie = Categorie.SterkeDrank;
                    break;
                case "K":
                    categorie = Categorie.KoffieThee;
                    break;
                case "LV":
                    categorie = Categorie.LunchVoorgerecht;
                    break;
                case "LH":
                    categorie = Categorie.LunchHoofdgerecht;
                    break;
                case "LN":
                    categorie = Categorie.LunchNagerecht;
                    break;
                case "DV":
                    categorie = Categorie.DinerVoorgerecht;
                    break;
                case "DT":
                    categorie = Categorie.DinerTussengerecht;
                    break;
                case "DH":
                    categorie = Categorie.DinerHoofdgerecht;
                    break;
                case "DN":
                    categorie = Categorie.DinerNagerecht;
                    break;
                default:
                    throw new DataMisalignedException("Niet bestaande categorie gebruikt!");
                
            }
            int bestellingId = data.GetFieldValue<int>(8);
            int btwPercentage = data.GetFieldValue<int>(9);

            return new BestellingsitemModel(naam, commentaar, hoeveelheid, tafelId, id, timestamp, prijs, categorie, bestellingId, btwPercentage);
        }

        private BestellingsitemModel LeesBestellingsItemMetStatus(SqlDataReader data)
        {
            BestellingsitemModel item = LeesBestellingsItem(data);

            switch (data.GetFieldValue<string>(10))
            {
                case "besteld":
                    item.Status = BestellingsItemStatus.besteld;
                    break;
                case "gereed":
                    item.Status = BestellingsItemStatus.gereed;
                    break;
                case "afgeleverd":
                    item.Status = BestellingsItemStatus.afgeleverd;
                    break;
            }
            return item;
        }

    }
}
