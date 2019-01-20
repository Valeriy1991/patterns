using System;
using _12.CompoundPatterns.Ducks;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Decorators;
using _12.CompoundPatterns.Geese;

namespace _12.CompoundPatterns
{
    public class DuckSimulator
    {
        public void Simulate()
        {
            var mallardDuck = new QuackCounterDecorator(new MallardDuck());
            var redheadDuck = new QuackCounterDecorator(new RedheadDuck());
            var duckCall = new QuackCounterDecorator(new DuckCall());
            var rubberDuck = new QuackCounterDecorator(new RubberDuck());
            var goose = new GooseAdapter(new Goose());

            Console.WriteLine("\n--- Duck simulator ---\n");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(goose);

            Console.WriteLine($"The ducks quacked {QuackCounterDecorator.AllQuacksCount} times");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}