using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Geese.Factories
{
    public abstract class AbstractGooseAdapterFactory
    {
        public abstract IQuackable CreateGooseAdapter();
    }
}