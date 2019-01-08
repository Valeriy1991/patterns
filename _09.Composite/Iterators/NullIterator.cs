using System.Collections;
using System.Collections.Generic;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Iterators
{
    /// <summary>
    /// Пустой итератор, не выполняющий операций
    /// </summary>
    public class NullIterator : IEnumerator<MenuComponent>
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new System.InvalidOperationException();
        }

        public MenuComponent Current => GetCurrent();

        private MenuComponent GetCurrent()
        {
            return null;
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new System.InvalidOperationException();
        }
    }
}