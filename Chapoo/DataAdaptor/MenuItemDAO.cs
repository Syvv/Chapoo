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
        public List<MenuItemModel> GetCategoriseerdeMenuItems(Categorie categorie)
        {

            List<MenuItemModel> menuList = new List<MenuItemModel>();
            StringBuilder sb = new StringBuilder();
            string categorieString = "";

            connection.Open();

            switch (categorie)
            {
                case Categorie.LunchVoorgerecht:
                    categorieString = "LV";
                    break;
                case Categorie.LunchHoofdgerecht:
                    categorieString = "LH";
                    break;
                case Categorie.LunchNagerecht:
                    categorieString = "LN";
                    break;
                case Categorie.DinerVoorgerecht:
                    categorieString = "DV";
                    break;
                case Categorie.DinerTussengerecht:
                    categorieString = "DT";
                    break;
                case Categorie.DinerHoofdgerecht:
                    categorieString = "DH";
                    break;
                case Categorie.DinerNagerecht:
                    categorieString = "DN";
                    break;
                case Categorie.Frisdrank:
                    categorieString = "F";
                    break;
                case Categorie.Bier:
                    categorieString = "B";
                    break;
                case Categorie.Wijn:
                    categorieString = "W";
                    break;
                case Categorie.SterkeDrank:
                    categorieString = "G";
                    break;
                case Categorie.KoffieThee:
                    categorieString = "K";
                    break;
            }

            sb.Append("SELECT * FROM MENU WHERE categorie = @categorie");

            SqlDataReader data;
            String sql = sb.ToString();
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@categorie", categorieString);
                data = cmd.ExecuteReader();
            }

            while (data.Read())
            {
                int menuId = (int)data["menu_id"];
                string menuItem = (string)data["item"];
                double prijs = (double)data["prijs"];
                int voorraad = (int)data["voorraad"];

                MenuItemModel menu = new MenuItemModel(menuId, menuItem, prijs, categorie, voorraad);

                menuList.Add(menu);
            }

            connection.Close();
            return menuList;
        }
    }
}
