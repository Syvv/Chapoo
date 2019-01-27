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
        private MenuItemDAO Items { get; set; }
        private List<MenuItem> MenuItemsCat { get; set; }

        public List<MenuItem> GetItems()
        {
            Items = new MenuItemDAO();
            return Items.GetMenuItems();
        }
        public List<MenuItem> Categoriseren(List<MenuItem> menuItemList, Categorie categorie)
        {
            foreach(MenuItem menuItem in menuItemList)
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
