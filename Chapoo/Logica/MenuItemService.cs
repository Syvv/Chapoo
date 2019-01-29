using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class MenuItemService
    {

        public List<MenuItemModel> GetItems(DAOFactory factory)
        {
            MenuItemDAO Items = factory.CreateMenuItemDAO();
            return Items.GetMenuItems();
        }
        public List<MenuItemModel> Categoriseren(List<MenuItemModel> menuItemList, Categorie categorie)
        {
            List<MenuItemModel> MenuItemsCat = new List<MenuItemModel>();
            foreach(MenuItemModel menuItem in menuItemList)
            {
                if(menuItem.Categorie == categorie)
                {
                    MenuItemsCat.Add(menuItem);
                }
            }
            return MenuItemsCat;
        }
    }
}
