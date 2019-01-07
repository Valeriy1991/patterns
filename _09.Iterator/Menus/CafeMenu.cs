using System.Collections.Generic;
using _09.Iterator.Iterators.Abstract;
using _09.Iterator.Menus.Abstract;

namespace _09.Iterator.Menus
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new Dictionary<string, MenuItem>();

        public CafeMenu()
        {
            AddMenuItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99M);
            AddMenuItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69M);
            AddMenuItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29M);
        }

        public void AddMenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            var menuItem = new MenuItem(name, description, isVegetarian, price);
            _menuItems.Add(name, menuItem);
        }
        
        public IIterator<MenuItem> CreateIterator()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }

    }
}