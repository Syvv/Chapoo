﻿using System;
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

        public WerknemerModel CheckLogin(string gebruikersnaam, string wachtwoord)
        {
            StringBuilder sb = new StringBuilder();
            connection.Open();

            sb.Append(  "SELECT functie, werknemerId " +
                        "FROM WERKNEMER " +
                        "WHERE inlogNaam = @gebruikersnaam AND wachtwoord = @wachtwoord;");
            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            SqlParameter gebruikersnaamparam = new SqlParameter("@gebruikersnaam", System.Data.SqlDbType.VarChar, 32) { Value = gebruikersnaam};
            SqlParameter wachtwoordparam = new SqlParameter("@wachtwoord", System.Data.SqlDbType.VarChar, 32) { Value = wachtwoord};
            command.Parameters.Add(gebruikersnaamparam);
            command.Parameters.Add(wachtwoordparam);

            SqlDataReader data = command.ExecuteReader();
            if(!data.HasRows)
            {
                connection.Close();
                throw new NoSuchUserException();
            }
            data.Read();

            //lees alle waardes uit
            //gebruikersnaam klopt al dus die kan je overnemen uit de parameters
            Functie functie;
            switch (data.GetFieldValue<string>(0))
            {
                case "bediening":
                    functie = Functie.Bediening;
                    break;
                case "bar":
                    functie = Functie.Bar;
                    break;
                case "keuken":
                    functie = Functie.Keuken;
                    break;
                default:
                    throw new DataMisalignedException("Deze gebruiker heeft een niet bestaande functie!");
            }
            int id = data.GetFieldValue<int>(1);

            WerknemerModel werknemer = new WerknemerModel(gebruikersnaam, id, functie);

            connection.Close();
            return werknemer;
        }

    }
}
