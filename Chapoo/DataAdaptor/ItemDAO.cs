using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAdaptor
{
    public class ItemDAO
    {
        public List<Item> GetMenuItems()
        {
            List<Item> menuList = new List<Item>();
            SqlDataReader data;

            data = DataConnection.Query("SELECT * FROM MENU");

            while (data.Read())
            {
                int menuId = (int)data["menu_id"];
                string menuItem = (string)data["item"];
                double prijs = (double)data["prijs"];
                Categorie categorie = (Categorie)data["categorie"];
                int voorraad = (int)data["voorraad"];

               // Item menu = new Item();

               // menuList.Add(menu);
            }

            DataConnection.connection.Close();
            return menuList;
        }
    }
}

