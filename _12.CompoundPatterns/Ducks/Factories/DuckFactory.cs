using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Decorators;

namespace _12.CompoundPatterns.Ducks.Factories
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}