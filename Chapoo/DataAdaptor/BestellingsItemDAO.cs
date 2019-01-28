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

        public List<Bestellingsitem> HaalBarItemsOp()
        {
            List<Bestellingsitem> result = new List<Bestellingsitem>();
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, h.commentaar, h.hoeveelheid, b.tafelId, m.menu_id, h.timestamp, m.prijs, m.categorie " +
                        "FROM HEEFT_ITEM h " +
                        "INNER JOIN MENU m ON h.menuId = m.menu_id " +
                        "INNER JOIN BESTELLING b ON b.bestellingId = h.bestellingId " +
                        "WHERE (m.categorie = 'F' OR m.categorie = 'B' OR m.categorie = 'W' OR m.categorie = 'G' OR m.categorie = 'K') AND status = 'besteld'");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            SqlDataReader data = command.ExecuteReader();
            //lees alle waardes uit
            while(data.Read())
            {
                string naam = data.GetFieldValue<string>(0);
                string commentaar = data.GetFieldValue<string>(1);
                int hoeveelheid = data.GetFieldValue<int>(2);
                int tafelId = data.GetFieldValue<int>(3);
                int id = data.GetFieldValue<int>(4);
                DateTime timestamp = data.GetFieldValue<DateTime>(5);
                double prijs = data.GetFieldValue<double>(6);
                Categorie categorie;
                switch(data.GetFieldValue<string>(7))
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
                    default:
                        throw new DataMisalignedException("Niet bestaande categorie gebruikt!");
                }
                result.Add(new Bestellingsitem(naam,commentaar,hoeveelheid,tafelId,id,timestamp,prijs,categorie));
            }
            connection.Close();
            return result;
        }

        public List<Bestellingsitem> HaalKeukenItemsOp()
        {
            List<Bestellingsitem> result = new List<Bestellingsitem>();
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, h.commentaar, h.hoeveelheid, b.tafelId, m.menu_id, h.timestamp, m.prijs, m.categorie " +
                        "FROM HEEFT_ITEM h " +
                        "INNER JOIN MENU m ON h.menuId = m.menu_id " +
                        "INNER JOIN BESTELLING b ON b.bestellingId = h.bestellingId " +
                        "WHERE (m.categorie = 'LV' OR m.categorie = 'LH' OR m.categorie = 'LN' OR m.categorie = 'DV' OR m.categorie = 'DT' OR m.categorie = 'DH' " +
                        "OR m.categorie = 'DN') AND status = 'besteld'");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);

            SqlDataReader data = command.ExecuteReader();
            //lees alle waardes uit
            while (data.Read())
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
                result.Add(new Bestellingsitem(naam, commentaar, hoeveelheid, tafelId, id, timestamp, prijs, categorie));
            }
            connection.Close();
            return result;
        }

        public List<Bestellingsitem> HaalAlleItemsOp(int bestellingsId)
        {
            List<Bestellingsitem> result = new List<Bestellingsitem>();
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, h.commentaar, h.hoeveelheid, b.tafelId, m.menu_id, h.timestamp, m.prijs, m.categorie " +
                        "FROM HEEFT_ITEM h " +
                        "INNER JOIN MENU m ON h.menuId = m.menu_id " +
                        "INNER JOIN BESTELLING b ON b.bestellingId = h.bestellingId " +
                        "WHERE h.bestellingsId = @bestellingsId");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@bestellingsId",bestellingsId);

            SqlDataReader data = command.ExecuteReader();
            //lees alle waardes uit
            while (data.Read())
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

                result.Add(new Bestellingsitem(naam, commentaar, hoeveelheid, tafelId, id, timestamp, prijs, categorie));
            }
            connection.Close();
            return result;
        }

    }
}
