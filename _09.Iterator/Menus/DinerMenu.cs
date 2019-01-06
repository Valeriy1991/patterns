using System;

namespace _09.Iterator.Menus
{
    public class DinerMenu
    {
        private int _menuItemIndex = 0;
        
        public const int MenuMaxItems = 6;
        public MenuItem[] MenuItems { get; private set; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MenuMaxItems];
        }

        public void AddMenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            if (_menuItemIndex >= MenuMaxItems)
            {
                throw new Exception("Sorry, menu is full! Can't add item to menu");
            }

            MenuItems[_menuItemIndex] = menuItem;
            _menuItemIndex = _menuItemIndex + 1;
        }
    }
}