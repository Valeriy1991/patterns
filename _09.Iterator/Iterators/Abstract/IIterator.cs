using _09.Iterator.Menus;

namespace _09.Iterator.Iterators.Abstract
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}