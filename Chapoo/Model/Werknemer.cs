using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Werknemer
    {
        public string Naam { get; set; }
        public int Id { get; set; }
        public Functie Functie { get; set; }

        public Werknemer(string name, int id, Functie type)
        {
            this.Naam = name;
            this.Id = id;
            this.Functie = type;
        }
        public Werknemer(int werknemerId)
        {
            this.Id = werknemerId;
        }
    }
}
