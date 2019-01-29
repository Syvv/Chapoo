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
        //private List<MenuItemModel> MenuItemsCat { get; set; }

        public List<MenuItemModel> GetItems()
        {
            MenuItemDAO Items = DAOFactory.Instance.CreateMenuItemDAO();
            return Items.GetMenuItems();
        }

        public List<MenuItemModel> Categoriseren(Categorie categorie)
        {
            MenuItemDAO Items = DAOFactory.Instance.CreateMenuItemDAO();
            return Items.GetCategoriseerdeMenuItems(categorie);
        }
    }
}
