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
        private readonly DinerMenu _dinerMenu;
        private readonly PancakeHouseMenu _breakfastMenu;

        public Waitress(DinerMenu dinerMenu, PancakeHouseMenu breakfastMenu)
        {
            _dinerMenu = dinerMenu;
            _breakfastMenu = breakfastMenu;
        }
        
        public void PrintMenu()
        {
            IIterator<MenuItem> breakfastIterator = _breakfastMenu.CreateIterator();
            IIterator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU");
            Console.WriteLine("--- BREAKFAST ---");
            PrintMenu(breakfastIterator);
            
            Console.WriteLine("\n--- LUNCH ---");
            PrintMenu(dinerIterator);
        }
        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                PrintMenuItem(iterator.Next());
            }
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
            Console.WriteLine($"{menuItem.Name}  {menuItem.Price}\n  {menuItem.Description}");
        }
    }
}