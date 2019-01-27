using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAdaptor
{
    public class MenuItemDAO
    {
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuList = new List<MenuItem>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM MENU");

            while (data.Read())
            {
                int menuId = (int)data["menu_id"];
                string menuItem = (string)data["item"];
                double prijs = (double)data["prijs"];
                string categorieString = (string)data["categorie"];
                int voorraad = (int)data["voorraad"];

                Enum.TryParse(categorieString, out CategorieEnum categorie);

                MenuItem menu = new MenuItem(menuId, menuItem, prijs, categorie, voorraad);

                menuList.Add(menu);
            }

            DataConnection.connection.Close();
            return menuList;
        }
    }
}
