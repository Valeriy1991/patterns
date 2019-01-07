using System.Collections.Generic;
using _09.Composite.Iterators.Abstract;

namespace _09.Composite.Menus.Abstract
{
    public interface IMenu
    {
        IIterator<MenuItem> CreateIterator();
        IEnumerator<MenuItem> GetEnumerator();
    }
}