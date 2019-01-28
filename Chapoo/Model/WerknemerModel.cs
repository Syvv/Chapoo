using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WerknemerModel
    {
        public string Naam { get; set; }
        public int Id { get; set; }
        public Functie Functie { get; set; }

        public WerknemerModel(string name, int id, Functie type)
        {
            this.Naam = name;
            this.Id = id;
            this.Functie = type;
        }
        public WerknemerModel(int werknemerId)
        {
            this.Id = werknemerId;
        }
    }
}
