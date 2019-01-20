using System;
using _12.CompoundPatterns.Ducks;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Decorators;
using _12.CompoundPatterns.Ducks.Factories;
using _12.CompoundPatterns.Geese;

namespace _12.CompoundPatterns
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            var mallardDuck = duckFactory.CreateMallardDuck();
            var redheadDuck = duckFactory.CreateRedheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
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