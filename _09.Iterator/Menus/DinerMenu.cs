using System;
using _09.Iterator.Iterators;
using _09.Iterator.Iterators.Abstract;

namespace _09.Iterator.Menus
{
    public class DinerMenu
    {
        private int _menuItemIndex = 0;
        private readonly MenuItem[] _menuItems;
        
        public const int MenuMaxItems = 6;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MenuMaxItems];
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
    }
}