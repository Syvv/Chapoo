using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestelOverzichtItemModel
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Aantal { get; set; }
        public string Opmerking { get; set; }

        public BestelOverzichtItemModel(int id, string item, int aantal, string opmerking)
        {
            this.Id = id;
            this.Item = item;
            this.Aantal = aantal;
            this.Opmerking = opmerking;
        }
    }
}
