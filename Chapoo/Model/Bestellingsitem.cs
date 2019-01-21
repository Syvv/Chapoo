using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestellingsitem
    {
        string name;string comment;int amount;int tafel;int id;int originalAmount;int menuId;DateTime timestamp;

        public string Name { get => name; set => name = value; }
        public string Comment { get => comment; set => comment = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Tafel { get => tafel; set => tafel = value; }
        public int Id { get => id; set => id = value; }
        public int OriginalAmount { get => originalAmount; set => originalAmount = value; }
        public int MenuId { get => menuId; set => menuId = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }

        public Bestellingsitem(string name, string comment, int amount, int tafel, int id, int menuId, DateTime timestamp)
        {
            Name = name;
            Comment = comment;
            Amount = amount;
            Tafel = tafel;
            Id = id;
            OriginalAmount = amount;
            MenuId = menuId;
            Timestamp = timestamp;
        }
    }

    public static class BestelLijst
    {
        static List<Bestellingsitem> list = new List<Bestellingsitem>();
        public static List<Bestellingsitem> List { get => list; set => list = value; }
    }

    public static class BestellingsGeheugen
    {
        //create an array of empty lists, each array corresponds to a table
        private static List<Bestellingsitem>[] ReadyOrders = new List<Bestellingsitem>[] {new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>(), new List<Bestellingsitem>() };

        public static void AddToReadyList(Bestellingsitem toAdd)
        {
            ReadyOrders[toAdd.Tafel - 1].Add(toAdd);
        }

        public static Bestellingsitem[] OrderIsReady(int tableID)
        {
            Bestellingsitem[] res = new Bestellingsitem[ReadyOrders[tableID - 1].Count];
            ReadyOrders[tableID - 1].CopyTo(res);
            ReadyOrders[tableID - 1].Clear();
            return res;
        }
    }

}
