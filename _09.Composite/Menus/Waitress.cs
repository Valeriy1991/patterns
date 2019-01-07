using System;
using System.Collections.Generic;
using _09.Composite.Iterators.Abstract;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Menus
{
    /// <summary>
    /// Официантка :)
    /// </summary>
    public class Waitress
    {
        private readonly IMenu _dinerMenu;
        private readonly IMenu _breakfastMenu;
        private readonly IMenu _cafeMenu;

        public Waitress(IMenu dinerMenu, IMenu breakfastMenu, IMenu cafeMenu)
        {
            _dinerMenu = dinerMenu;
            _breakfastMenu = breakfastMenu;
            _cafeMenu = cafeMenu;
        }
        
        public void PrintMenu()
        {
//            IIterator<MenuItem> breakfastIterator = _breakfastMenu.CreateIterator();
//            IIterator<MenuItem> dinerIterator = _dinerMenu.CreateIterator();
            var breakfastIterator = _breakfastMenu.GetEnumerator();
            var dinerIterator = _dinerMenu.GetEnumerator();
            var cafeIterator = _cafeMenu.GetEnumerator();

            Console.WriteLine("MENU");
            Console.WriteLine("--- BREAKFAST ---");
            PrintMenu(breakfastIterator);
            
            Console.WriteLine("\n--- LUNCH ---");
            PrintMenu(dinerIterator);
            
            Console.WriteLine("\n--- DINNER ---");
            PrintMenu(cafeIterator);
        }
        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                PrintMenuItem(iterator.Next());
            }
        }
        private void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                PrintMenuItem(iterator.Current);
            }
        }

        /*public void PrintBreakfastMenu()
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
        }*/
        
        private void PrintMenuItem(MenuItem menuItem)
        {
            Console.WriteLine($"{menuItem.Name}  {menuItem.Price}\n  {menuItem.Description}");
        }
    }
}