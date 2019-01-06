using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bestelling
    {
        int tafelId;int werknemerId;

        public int TafelId { get => tafelId; set => tafelId = value; }
        public int WerknemerId { get => werknemerId; set => werknemerId = value; }

        public Bestelling(int tafelId, int werknemerId)
        {
            TafelId = tafelId;
            WerknemerId = werknemerId;
        }
        public class BestellingList
        {
            List<Bestelling> bl = new List<Bestelling>();
            public void addList(Bestelling b)
            {
                bl.Add(b);
            }

            public List<Bestelling> getList()
            {
                return bl;
            }
        }
    }
}
