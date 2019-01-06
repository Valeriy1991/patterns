using System.Collections.Generic;
using _09.Iterator.Iterators.Abstract;

namespace _09.Iterator.Menus.Abstract
{
    public interface IMenu
    {
        IIterator<MenuItem> CreateIterator();
        IEnumerator<MenuItem> GetEnumerator();
    }
}