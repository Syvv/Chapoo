using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdaptor
{
    public class MenuDAO
    {
        public static List<Model.MenuModel> GetMenuItems()
        {
            List<Model.MenuModel> menu_list = new List<Model.MenuModel>();
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

                Model.MenuModel menu = new Model.MenuModel(menuId, menuItem, prijs, categorie, voorraad);

                menu_list.Add(menu);
                
            }

            DataConnection.connection.Close();
            return menu_list;
        }
    }
}
