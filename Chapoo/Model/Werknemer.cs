using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum FunctieType { Bediening, Keuken, Bar }

    public class Werknemer
    {
        public string Naam { get; set; }
        public int Id { get; set; }
        public FunctieType Functie { get; set; }

        public Werknemer(string name, int id, FunctieType type)
        {
            this.Naam = name;
            this.Id = id;
            this.Functie = type;
        }
        
    }
}
