using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Categorie { LunchVoorgerecht, LunchHoofdgerecht, LunchNagerecht, DinerVoorgerecht, DinerTussengerecht, DinerHoofdgerecht, DinerNagerecht, Frisdrank, Bier, Wijn, SterkeDrank, KoffieThee }
    public enum Functie { Bar, Bediening, Keuken }
    public enum Status { vrij, bezet, gereserveerd }
    public enum BetaalMethode{ nog_niet, pin, cash, creditcard}
    public enum BestellingsItemStatus { besteld, gereed, afgeleverd}
}
