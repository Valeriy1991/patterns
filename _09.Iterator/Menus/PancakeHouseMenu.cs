using System.Collections;
using System.Collections.Generic;

namespace _09.Iterator.Menus
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItems { get; private set; }

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs, and toast",
                    true,
                    2.99M),

                new MenuItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage",
                    false,
                    2.99M),

                new MenuItem("Blueberry Pancakes",
                    "Pancakes made with fresh blueberries",
                    true,
                    3.49M),

                new MenuItem("Waffles",
                    "Waffles, with your choice of blueberries or strawberries",
                    true,
                    3.59M)
            };
        }
    }
}