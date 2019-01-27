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
        private SqlConnection connection = DataConnection.connection;
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
    }
}
