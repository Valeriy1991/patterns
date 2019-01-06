using System.Collections.Generic;
using _09.Iterator.Iterators.Abstract;
using _09.Iterator.Menus;

namespace _09.Iterator.Iterators
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        private readonly List<MenuItem> _items;
        private int _position;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            _items = menuItems;
        }
        
        public bool HasNext()
        {
            return _position < _items.Count && _items[_position] != null;
        }

        public MenuItem Next()
        {
            var menuItem = _items[_position];
            _position = _position + 1;
            return menuItem;
        }
    }
}