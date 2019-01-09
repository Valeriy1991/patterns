using System;
using System.Collections.Generic;
using _09.Composite.Menus;
using _09.Composite.Menus.Abstract;

namespace _09.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = MenuFactory.Create();
            
            var waitress = new Waitress(menu);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();
        }

        
    }
}