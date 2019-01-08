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
    }
}