﻿using System;
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
        private List<MenuItemModel> MenuItemsCat { get; set; }

        public List<MenuItemModel> GetItems()
        {
            Items = new MenuItemDAO();
            return Items.GetMenuItems();
        }
        public List<MenuItemModel> Categoriseren(List<MenuItemModel> menuItemList, Categorie categorie)
        {
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
