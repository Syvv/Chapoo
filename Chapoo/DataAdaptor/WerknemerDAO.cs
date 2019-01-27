using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAdaptor
{
    public class WerknemerDAO
    {
        private SqlConnection connection;

        public WerknemerDAO(SqlConnection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public Werknemer CheckLogin(string gebruikersnaam, string wachtwoord)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append(  "SELECT functie, id " +
                        "FROM WERKNEMER " +
                        "WHERE inlog_naam = '@gebruikersnaam' AND wachtwoord = '@wachtwoord';");

            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            command.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
            command.Parameters.AddWithValue("@wachtwoord", wachtwoord);

            SqlDataReader data = command.ExecuteReader();
            if(!data.HasRows)
            {
                throw new NoSuchUserException();
            }
            data.Read();

            //lees alle waardes uit
            //gebruikersnaam klopt al dus die kan je overnemen uit de parameters
            FunctieType functie;
            switch (data.GetFieldValue<string>(0))
            {
                case "bediening":
                    functie = FunctieType.Bediening;
                    break;
                case "bar":
                    functie = FunctieType.Bar;
                    break;
                case "keuken":
                    functie = FunctieType.Keuken;
                    break;
                default:
                    throw new DataMisalignedException("Deze gebruiker heeft een niet bestaande functie!");
            }
            int id = data.GetFieldValue<int>(1);

            Werknemer werknemer = new Werknemer(gebruikersnaam, id, functie);
            return werknemer;
        }

    }
}
