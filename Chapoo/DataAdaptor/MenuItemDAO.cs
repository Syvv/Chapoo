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
        private readonly SqlConnection connection = DataConnection.connection;

        public List<MenuItemModel> GetMenuItems()
        {
            List<MenuItemModel> menuList = new List<MenuItemModel>();
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT * FROM MENU");

            connection.Open();
            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                int menuId = (int)data["menu_id"];
                string menuItem = (string)data["item"];
                double prijs = (double)data["prijs"];
                string categorieString = (string)data["categorie"];
                int voorraad = (int)data["voorraad"];

                Enum.TryParse(categorieString, out Categorie categorie);

                MenuItemModel menu = new MenuItemModel(menuId, menuItem, prijs, categorie, voorraad);

                menuList.Add(menu);
            }

            connection.Close();
            return menuList;
        }
    }
}
