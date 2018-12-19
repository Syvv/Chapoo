using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

        public static List<string>OphalenBestellingen(int bestellingId)
        {
            List<string> bestelling = new List<string>();
            string query = "Select * from * where BestellingId = '@bestellingId' ";
            query = query.Replace("@bestellingId", bestellingId.ToString());

            SqlDataReader data = DataConnection.Query(query);

            while (data.Read())
            {
                bestelling.Add(data.GetFieldValue<int>(0) + " - " + data.GetFieldValue<string>(1));
            }
            return bestelling;
        }
        //public static List<string>2OphalenBestellingen(int bestellingId)
        //{
        //    List<string> bestelling = new List<string>();

        //    string query = "Select * from * where BestellingId = '@bestellingId' ";
        //    query = query.Replace("@bestellingId", bestellingId.ToString());


        //    return bestelling;
        //}

        public int BestellingIdOpvragen(int tafelNummer)
        {
            string query = "SELECT bestellingId FROM bestelling Where tafel_id = '@_tafelid'";
            query = query.Replace("@_tafelid", tafelNummer.ToString());

            SqlDataReader bestellingNummer = DataConnection.Query(query);
            int bestellingId = int.Parse(bestellingNummer.ToString());

            return bestellingId;
        }

        public 
    }
}
