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

        public List<Menu>OphalenBestellingen(int bestellingId)
        {
            List<Menu> bestelling = new List<Menu>();

            string query = "Select * from * where BestellingId = '@bestellingId' ";  //sql nog maken
            query = query.Replace("@bestellingId", bestellingId.ToString());

            SqlDataReader data = DataConnection.Query(query);
            
            while (data.Read())
            {
                bestelling.Add(new Menu(data.GetFieldValue<int>(0),
                                        data.GetFieldValue<string>(1),
                                        data.GetFieldValue<double>(2),
                                        data.GetFieldValue<char>(3),
                                        data.GetFieldValue<int>(4))
                                        );
            }
            return bestelling;
        }


        public int BestellingIdOpvragen(int tafelNummer)
        {
            string query = "SELECT bestellingId FROM bestelling Where tafel_id = '@_tafelid'";
            query = query.Replace("@_tafelid", tafelNummer.ToString());

            SqlDataReader bestellingNummer = DataConnection.Query(query);
            int bestellingId = int.Parse(bestellingNummer.ToString());

            //db sluiten
            return bestellingId;
        }

        /*public List<Menu> MenuOphalen()
        {
            Menu menu = new Menu(0, null, 0, '0', 0);
            string query = "SELECT * FROM MENU";

            SqlDataReader data = DataConnection.Query(query);

            while (data.Read())
            {
                menu = new Menu((int)data["menu_id"], 
                                (string)data["item"], 
                                (double)data["prijs"], 
                                (char)data["categorie"], 
                                (int)data["voorraad"]);
            }
            data.Close();
            return menu;
        }*/
        public void WegSchrijvenBestelling()//bestelling meegeven
        {
            string query = ("INSERT ### INTO BESTELLING");
        }
    }
}
