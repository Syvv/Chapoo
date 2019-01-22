using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{

    public class User
    {

        public static char TestLoginInfo(string user, string pass)
        {
            SqlDataReader res = DataAdaptor.UserConnection.CheckLogin(user, pass);
            if(!res.HasRows)
            {
                throw new Model.NoSuchUserException();
            }
            else
            {
                res.Read();
                string type = res.GetFieldValue<string>(1);
                DataAdaptor.DataConnection.connection.Close();
                switch (type)
                {
                    case "bediening":
                        return 's';
                    case "bar":
                        return 'b';
                    case "keuken":
                        return 'k';
                    default:
                        throw new DataMisalignedException("The Employeetype of that user is invalid!");
                };

            }
        }

    }
}
