using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestellingsitem
    {
        string name;string comment;int amount;int tafel;int id;

        public string Name { get => name; set => name = value; }
        public string Comment { get => comment; set => comment = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Tafel { get => tafel; set => tafel = value; }
        public int Id { get => id; set => id = value; }

        public Bestellingsitem(string name, string comment, int amount, int tafel, int id)
        {
            Name = name;
            Comment = comment;
            Amount = amount;
            Tafel = tafel;
            Id = id;
        }
    }

    public static class BestelLijst
    {
        static List<Bestellingsitem> list = new List<Bestellingsitem>();
        public static List<Bestellingsitem> List { get => list; set => list = value; }
    }

}
