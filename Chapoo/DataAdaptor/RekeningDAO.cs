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
        private SqlConnection connection;
        public RekeningDAO(SqlConnection connection)
        {
            this.connection = connection;
        }
        
        public void InsertRekening(Rekening rekening)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("INSERT INTO REKENING(bestellingId, totaalbedrag, fooi, opmerking, betaalmanier) VALUES(@bestellingId, @totaalbedrag, @fooi, @opmerking , @betaalmanier)");
            using(SqlCommand command = new SqlCommand(sb.ToString(), connection))
            {
                command.Parameters.AddWithValue("@bestellingId", rekening.Bestelling.Id);
                command.Parameters.AddWithValue("@totaalbedrag", rekening.Totaalbedrag);
                command.Parameters.AddWithValue("@fooi", rekening.Fooi);
                command.Parameters.AddWithValue("@opmerking", rekening.Opmerking);
                command.Parameters.AddWithValue("@betaalmanier", rekening.Methode); //deze nog verandern
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        public List<Bestellingsitem> OphalenBestellingen(int bestellingId)
        {
            List<Bestellingsitem> bestellingen = new List<Bestellingsitem>();

            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT m.item, m.prijs, m.categorie, ht.hoeveelheid FROM HEEFT_ITEM as ht, MENU as m, BESTELLING as b Where b.bestellingid = ht.bestellingId and ht.menuid = m.menu_id and b.bestellingId = @bestellingId");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@bestellingId", bestellingId);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string naam = reader.GetString(0);
                int hoeveelheid = reader.GetInt32(3);
                double prijs = reader.GetDouble(1);
                Categorie categorie = (Categorie)reader.GetValue(2);

                string commentaar = "";
                int tafel = 0;
                int id = bestellingId;
                DateTime timestamp = DateTime.MinValue;

                Bestellingsitem x = new Bestellingsitem(naam, commentaar, hoeveelheid, tafel,id,timestamp , prijs, categorie,0);

                bestellingen.Add(x);
            }

            connection.Close();
            return bestellingen;
        }

    }
}
