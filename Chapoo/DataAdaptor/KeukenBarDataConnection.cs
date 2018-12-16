using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public static class KeukenBarDataConnection
    {
        private static DataConnection db = new DataConnection();
        
        public static List<string> GetOpenOrders(bool isBar)
        {
            throw new NotImplementedException("KeukenBarDataConnection.GetOpenOrders(bool isBar) is not yet implemented");
        }
    }
}
