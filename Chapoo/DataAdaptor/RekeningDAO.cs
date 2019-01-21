using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DataAdaptor
{
    public class RekeningDAO
    {
        public static void ZetTafelVrijmaken(int tafelId)
        {
            string query = "update TAFEL set Bezet = 0 where id = '@_tafelid'";
            query = query.Replace("@_tafelid", tafelId.ToString());

            SqlDataReader update;
            update = DataConnection.Query(query);
        }
        public int BestellingIdOpvragen(int tafelNummer)
        {
            string query = "SELECT bestelling_id FROM BESTELLING Where tafel_id = '@_tafelid'";
            query = query.Replace("@_tafelid", tafelNummer.ToString());

            SqlDataReader bestellingNummer = DataConnection.Query(query);
            int bestellingId = (int)bestellingNummer["bestelling_id"];

            //db sluiten
            DataConnection.connection.Close();
            return bestellingId;
        }
        public List<int>BestellingIdList(int tafelNummer)
        {
            List<int> bestellingnmr = new List<int>();
            string query = "SELECT bestelling_id FROM BESTELLING Where tafel_id = '@_tafelid'";
            query = query.Replace("@_tafelid", tafelNummer.ToString());

            SqlDataReader bestellingNummer = DataConnection.Query(query);
            while (bestellingNummer.Read())
            {
                int bestellingsId = (int)bestellingNummer["bestelling_id"];
                bestellingnmr.Add(bestellingsId);
            }

            //db sluiten
            DataConnection.connection.Close();
            return bestellingnmr;
        }

        public List<BesteldRekening>OphalenBestellingen(int bestellingId)
        {
            List<BesteldRekening> bestelling = new List<BesteldRekening>();

            string query = "SELECT m.menu_id, m.item, m.prijs, m.categorie, ht.amount FROM HEEFT_ITEM as ht, MENU as m, BESTELLING as b Where b.bestelling_id = ht.bestel_id and ht.menu_id = m.menu_id and b.bestelling_id = '@bestellingId'";
            
            query = query.Replace("@bestellingId", bestellingId.ToString());

            SqlDataReader data = DataConnection.Query(query);

            while (data.Read())
            {
                int menuId = (int)data["menu_id"];
                string menuItem = (string)data["item"];
                double prijs = (double)data["prijs"];
                string categorie = (string)data["categorie"];
                //int voorraad = (int)data["voorraad"];
                int hoeveelheid = (int)data["amount"];

                BesteldRekening besteld = new BesteldRekening(menuId, menuItem, prijs, categorie, 0, hoeveelheid);
                bestelling.Add(besteld);
            }

            DataConnection.connection.Close();
            return bestelling;
        }
        public void WegSchrijvenBestelling(Rekening rekening, int tafelid, int bestelling)//bestelling meegeven
        {
            SqlDataReader data;

            //string query = ("INSERT INTO REKENING (tafel_id, bestelling_id, totaalbedrag, tip, opmerking) VALUES(@tafel_id, @bestelling_id, @totaalbedrag, @tip, @opmerking)");
            //query.Replace("'@tafel_id'", tafelid.ToString());
            //query.Replace("'@bestelling_id'", bestelling.ToString());
            //query.Replace("'@totaalbedrag'", rekening.Totaalbedrag.ToString());
            //query.Replace("'@tip'", rekening.Fooi.ToString());
            //query.Replace("'@opmerking'", rekening.Opmerking);

            SqlConnection connection = DataConnection.connection;
            connection.Open();

            StringBuilder sb = new StringBuilder();
            String sql = sb.ToString();

            sb.Append("INSERT INTO REKENING (tafel_id, bestelling_id, totaalbedrag, tip, opmerking) VALUES(@tafel_id, @bestelling_id, @totaalbedrag, @tip, @opmerking)");

            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@tafel_id", tafelid);
                cmd.Parameters.AddWithValue("@bestelling_id", bestelling);
                cmd.Parameters.AddWithValue("@totaalbedrag", rekening.Totaalbedrag);
                cmd.Parameters.AddWithValue("@tip", rekening.Fooi);
                cmd.Parameters.AddWithValue("@opmerking", rekening.Opmerking);
                cmd.ExecuteNonQuery();
            }
            connection.Close();

            //nu de datareader nog            
            //data = DataConnection.Query(query);
            DataConnection.connection.Close();
        }
    }
}
