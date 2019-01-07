namespace _09.Composite.Iterators.Abstract
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}