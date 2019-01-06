using System;
using System.Collections.Generic;
using _09.Iterator.Iterators.Abstract;

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
            IIterator<MenuItem> iterator = _breakfastMenu.CreateIterator();

            while (iterator.HasNext())
            {
                var nextMenuItem = iterator.Next();
                PrintMenuItem(nextMenuItem);
            }
        }

        public void PrintLunchMenu()
        {
            IIterator<MenuItem> iterator = _dinerMenu.CreateIterator();

            while (iterator.HasNext())
            {
                var nextMenuItem = iterator.Next();
                PrintMenuItem(nextMenuItem);
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