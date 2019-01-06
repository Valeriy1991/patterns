using System.Collections;
using System.Collections.Generic;
using _09.Iterator.Iterators;
using _09.Iterator.Iterators.Abstract;

namespace _09.Iterator.Menus
{
    public class PancakeHouseMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>()
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

        public IIterator<MenuItem> CreateIterator()
        {
            return new PancakeHouseMenuIterator(_menuItems);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return ((IEnumerable<MenuItem>)_menuItems).GetEnumerator();
        }
    }
}