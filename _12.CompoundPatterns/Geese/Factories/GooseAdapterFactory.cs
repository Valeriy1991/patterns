using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Geese.Factories
{
    public class GooseAdapterFactory : AbstractGooseAdapterFactory
    {
        public override IQuackable CreateGooseAdapter()
        {
            return new GooseAdapter(new Goose());
        }
    }
}