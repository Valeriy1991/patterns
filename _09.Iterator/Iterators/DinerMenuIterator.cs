using System;
using _09.Iterator.Iterators.Abstract;
using _09.Iterator.Menus;

namespace _09.Iterator.Iterators
{
    public class DinerMenuIterator : IIterator<MenuItem>
    {
        private readonly MenuItem[] _items;
        private int _position;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }
        
        public bool HasNext()
        {
            return _position < _items.Length && _items[_position] != null;
        }

        public MenuItem Next()
        {
            var menuItem = _items[_position];
            _position = _position + 1;
            return menuItem;
        }
    }
}