using System;
using System.Collections.Generic;
using _09.Iterator.Menus;
using _09.Iterator.Menus.Abstract;

namespace _09.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            TryPrintMenuFromWaitress();
            TryPrintMenuFromWaitressWithMenus();
        }

        static void TryPrintMenuFromWaitress()
        {
            Console.WriteLine("\n---- Waitress ----");
            var breakfastMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();
            
            var waitress = new Waitress(dinerMenu, breakfastMenu, cafeMenu);
            waitress.PrintMenu();
        }

        static void TryPrintMenuFromWaitressWithMenus()
        {
            Console.WriteLine("\n---- Waitress with menu list ----");
            var breakfastMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();
            
            // Все хорошо, но потерялись заголовки меню
            var waitress = new WaitressWithMenus(new List<IMenu>()
            {
                breakfastMenu, dinerMenu, cafeMenu
            });
            waitress.PrintMenu();
        }
    }
}