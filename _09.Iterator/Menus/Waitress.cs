using System;
using System.Collections.Generic;

namespace _09.Iterator.Menus
{
    /// <summary>
    /// Официантка :)
    /// </summary>
    public class Waitress
    {
        private readonly DinerMenu _dinerMenu = new DinerMenu();
        private readonly PancakeHouseMenu _breakfastMenu = new PancakeHouseMenu();
        
        public void PrintMenu()
        {
            
        }

        public void PrintBreakfastMenu()
        {
            List<MenuItem> breakfastItems = _breakfastMenu.MenuItems;
            for (int i = 0; i < breakfastItems.Count; i++)
            {
                PrintMenuItem(breakfastItems[i]);
            }
        }

        public void PrintLunchMenu()
        {
            MenuItem[] lunchItems = _dinerMenu.MenuItems;
            for (int i = 0; i < lunchItems.Length; i++)
            {
                PrintMenuItem(lunchItems[i]);
            }
        }

        public void PrintVegetarianMenu()
        {
            
        }

        public bool IsItemVegetarian(string name)
        {
            return false;
        }

        private void PrintMenuItem(MenuItem menuItem)
        {
            Console.WriteLine($"{menuItem.Name}\n{menuItem.Price}\n{menuItem.Description}");
        }
    }
}