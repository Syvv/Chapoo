using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        string name; char type;

        public string Name { get => name; set => name = value; }
        public char Type { get => type; set => type = value; }

        public User(string name, char type)
        {
            Name = name;
            Type = type;
        }
    }
}
