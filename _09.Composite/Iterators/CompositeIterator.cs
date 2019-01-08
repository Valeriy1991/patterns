using System;
using System.Collections;
using System.Collections.Generic;
using _09.Composite.Menus;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Iterators
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        private readonly Stack _stack = new Stack();
        
        public CompositeIterator(IEnumerator<MenuComponent> enumerator)
        {
            _stack.Push(enumerator);
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0)
                return false;

            var iterator = (IEnumerator<MenuComponent>) _stack.Peek();
            if (!iterator.MoveNext())
            {
                _stack.Pop();
                return MoveNext();
            }

            return true;
        }

        public void Reset()
        {
            _stack.Clear();
        }

        public MenuComponent Current => GetCurrent();

        private MenuComponent GetCurrent()
        {
            if (MoveNext())
            {
                var iterator = (IEnumerator<MenuComponent>) _stack.Peek();
                var menuComponent = iterator.Current;
                if (menuComponent is Menu)
                {
                    _stack.Push(menuComponent.GetEnumerator());
                }

                return menuComponent;
            }

            return null;
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }
    }
}