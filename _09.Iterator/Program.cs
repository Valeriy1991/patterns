using System;
using _09.Iterator.Menus;

namespace _09.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var breakfastMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            
            var waitress = new Waitress(dinerMenu, breakfastMenu);
            waitress.PrintMenu();
        }
    }
}