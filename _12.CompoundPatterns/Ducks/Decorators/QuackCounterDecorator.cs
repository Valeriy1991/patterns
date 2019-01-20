using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Observation;

namespace _12.CompoundPatterns.Ducks.Decorators
{
    public class QuackCounterDecorator : IQuackable
    {
        private readonly IQuackable _duck;
        public static int AllQuacksCount { get; private set; } = 0;

        public QuackCounterDecorator(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            AllQuacksCount++;
            _duck.Quack();
        }

        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }
    }
}