using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public class Menu_DAO
    {
        public static List<Model.Menu> GetMenuItems()
        {
            List<Model.Menu> menu_list = new List<Model.Menu>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM MENU");

            int menuId;
            string menuItem;
            double prijs;
            string categorie;
            int voorraad;

            while (data.Read())
            {
                menuId = (int)data["menu_id"];
                menuItem = (string)data["item"];
                prijs = (double)data["prijs"];
                categorie = (string)data["categorie"];
                voorraad = (int)data["voorraad"];

                Model.Menu menu = new Model.Menu(menuId, menuItem, prijs, categorie, voorraad);

                menu_list.Add(menu);

            }
            data.Close();
            return menu_list;
        }
    }
}
