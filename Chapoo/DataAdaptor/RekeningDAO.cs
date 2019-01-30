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
        
        public void InsertRekening(RekeningModel rekening, int BestellingsId)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("INSERT INTO REKENING(bestellingId, totaalbedrag, fooi, opmerking, betaalmanier) VALUES(@bestellingId, @totaalbedrag, @fooi, @opmerking , @betaalmanier)");
            using(SqlCommand command = new SqlCommand(sb.ToString(), connection))
            {
                command.Parameters.AddWithValue("@bestellingId", BestellingsId);
                command.Parameters.AddWithValue("@totaalbedrag", rekening.Totaalbedrag);
                command.Parameters.AddWithValue("@fooi", rekening.Fooi);
                command.Parameters.AddWithValue("@opmerking", rekening.Opmerking);
                command.Parameters.AddWithValue("@betaalmanier", rekening.BetaalMethode);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        public int BestellingsIdOphalen(int tafelId)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("select b.bestellingId from BESTELLING as b where tafelId = @tafelId AND (bestellingId NOT IN (SELECT bestellingId from REKENING))");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@tafelId", tafelId);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            int bestellingsid = reader.GetInt32(0);

            connection.Close();
            return bestellingsid;
        }
    }
}
