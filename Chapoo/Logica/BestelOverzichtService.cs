using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class BestelOverzichtService
    {
        private BestellingOverzichtDAO OrderView = new BestellingOverzichtDAO();
        public void DeleteItem(int id, bool bar)
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
        public void ChangeItem(bool bar, int id, string comment, int aantal)
        {
            if (bar == true)
            {
                OrderView.ChangeInBarQueue(id, aantal, comment);
            }
            else
            {
                OrderView.ChangeInKeukenQueue(id, aantal, comment);
            }
        }
        public void DeleteAll(int id, bool bar)
        {
            if (bar == true)
            {
                OrderView.DeleteAllInBarQueue(id);
            }
            else
            {
                OrderView.DeleteAllInKeukenQueue(id);
            }
        }
        public void DeleteFromNotifications(int id)
        {
            OrderView.DeleteInNotificatie(id);
        }
    }
}
