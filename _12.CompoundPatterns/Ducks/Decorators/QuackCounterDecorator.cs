using _12.CompoundPatterns.Ducks.Abstract;

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
    }
}