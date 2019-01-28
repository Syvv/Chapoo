using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DataAdaptor
{
    public class TafelDAO
    {
        //Als iemand anders het ook gemaakt heeft, dit is tot nu toe mijn versie
        private SqlConnection connection;

        public TafelDAO(SqlConnection connection)
        {
            this.connection = connection;
        }
        public void TafelBezetMelden(int tafelId)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("update TAFEL set staat = 'bezet' where tafelId = @tafelId");
            using (SqlCommand command = new SqlCommand(sb.ToString(), connection))
            {
                command.Parameters.AddWithValue("@tafelId", tafelId);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void TafelVrijMelden(int tafelId)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("update TAFEL set staat = 'vrij' where tafelId = @tafelId");
            using (SqlCommand command = new SqlCommand(sb.ToString(), connection))
            {
                command.Parameters.AddWithValue("@tafelId", tafelId);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
        public Tafel TafelInfoVuller(int tafelId) //bestelling toevoegen
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append("SELECT zitplaatsen, staat FROM TAFEL WHERE tafelId = @tafelId ");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@tafelId", tafelId);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            int zitplaatsen = reader.GetInt32(0);
            string stringstatus = reader.GetString(1); //switch case van maken

            Status status;
            switch (stringstatus)
            {
                case ("vrij"):
                    status = Status.bezet;
                    break;
                case ("bezet"):
                    status = Status.bezet;
                    break;
                case ("gereserveerd"):
                    status = Status.gereserveerd;
                    break;
                default:
                    throw new DataMisalignedException("Deze status bestaat niet");
            }

            Tafel tafel = new Tafel(tafelId, status, zitplaatsen, null);
            
            connection.Close();
            return tafel;
        }
    }
}
