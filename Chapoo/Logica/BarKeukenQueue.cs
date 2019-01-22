using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logica
{
    public static class BarKeukenQueue
    {
        private static Model.User user;
        

        public static List<Bestellingsitem> getBestellingen(Model.User user)
        {
            BarKeukenQueue.user = user;
            List<Bestellingsitem> result = new List<Bestellingsitem>();
            SqlDataReader data;
            if (user.Type == 'b')//Check for user's occupation
            {
                data = KeukenBarDataConnection.GetOpenOrdersBar();
            }
            else
            {
                data = KeukenBarDataConnection.GetOpenOrdersKeuken();
            }
            BestelLijst.List.Clear(); //clear list of possible junk left over
            //fill with fresh data
            while (data.Read())
            {
                BestelLijst.List.Add(new Bestellingsitem(data.GetFieldValue<string>(1), data.GetFieldValue<string>(3), data.GetFieldValue<int>(2), data.GetFieldValue<int>(0), data.GetFieldValue<int>(4), data.GetFieldValue<int>(5), data.GetFieldValue<DateTime>(6)));
            }
            DataConnection.connection.Close();
            return BestelLijst.List;
        }

        public static void removeItemFromQueue(Bestellingsitem item)
        {
            if(user.Type == 'b')
            {
                KeukenBarDataConnection.RemoveOpenItemBar(item.Id);
            }
            else
            {
                KeukenBarDataConnection.RemoveOpenItemKeuken(item.Id);
            }
        }

        public static void SendNotification(int tafelID)
        {
            Bestellingsitem[] list = Model.BestellingsGeheugen.OrderIsReady(tafelID);
            KeukenBarDataConnection.CreateNotification(list);
        }

        public static void UpdateAmountInDataBase(Bestellingsitem item)
        {
            if(user.Type == 'b')
            {
                KeukenBarDataConnection.UpdateAmountBar(item);
            }
            else
            {
                KeukenBarDataConnection.UpdateAmountKeuken(item);
            }
        }

        public static void PreserveData()
        {
            Bestellingsitem[] list = Model.BestellingsGeheugen.GetAllOrders();
            if(list.Length!=0)
            {
                KeukenBarDataConnection.CreateNotification(list);
            }
            
        }
        
    }
}
