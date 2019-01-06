using System;
using System.Collections;
using System.Collections.Generic;
using _09.Iterator.Iterators;
using _09.Iterator.Iterators.Abstract;
using _09.Iterator.Menus.Abstract;

namespace _09.Iterator.Menus
{
    public class DinerMenu : IMenu
    {
        private int _menuItemIndex = 0;
        private readonly MenuItem[] _menuItems;
        
        public const int MenuMaxItems = 6;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MenuMaxItems];
            AddMenuItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);
            AddMenuItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99M);
            AddMenuItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29M);
            AddMenuItem("Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 3.05M);
            AddMenuItem("Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice", true, 3.99M);
            AddMenuItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 3.89M);
        }

        public void AddMenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            if (_menuItemIndex >= MenuMaxItems)
            {
                throw new Exception("Sorry, menu is full! Can't add item to menu");
            }

            _menuItems[_menuItemIndex] = menuItem;
            _menuItemIndex = _menuItemIndex + 1;
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return ((IEnumerable<MenuItem>)_menuItems).GetEnumerator();
        }
    }
}