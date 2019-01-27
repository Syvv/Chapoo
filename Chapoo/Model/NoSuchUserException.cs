using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NoSuchUserException : Exception
    {
        new const string Message = "There is no user with those credentials!";
        public NoSuchUserException():base(Message)
        {
        }

    }
}
