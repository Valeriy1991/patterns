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
        private readonly MenuComponent _menu;

        public Waitress(MenuComponent menu)
        {
            _menu = menu;
        }
        
        public void PrintMenu()
        {
            _menu.Print();
        }

        public void PrintVegetarianMenu()
        {
            using (var iterator = _menu.GetEnumerator())
            {
                Console.WriteLine("VEGETARIAN MENU\n----");
                while (iterator.MoveNext())
                {
                    var menuComponent = iterator.Current;
                    try
                    {
                        if (menuComponent.IsVegetarian())
                        {
                            // Будет вызван только для MenuItem и никогда - для Menu
                            menuComponent.Print();
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        // ignore
                    }
                }
            }
        }
    }
}