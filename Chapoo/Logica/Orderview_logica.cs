using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class Orderview_logica
    {
        protected Order_view_DAO OrderView = new Order_view_DAO();
        public void DeleteItem(bool confirmatie, int id, bool bar)
        {
            if(confirmatie == true)
            {
                if (bar == true)
                {
                    OrderView.DeleteFromBarQueue(id);
                }
                else
                {
                    OrderView.DeleteFromKeukenQueue(id);
                }
            }   
        }
    }
}
