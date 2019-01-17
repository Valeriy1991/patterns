using System;
using _12.CompoundPatterns.Ducks;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Geese;

namespace _12.CompoundPatterns
{
    public class DuckSimulator
    {
        public void Simulate()
        {
            var mallardDuck = new MallardDuck();
            var redheadDuck = new RedheadDuck();
            var duckCall = new DuckCall();
            var rubberDuck = new RubberDuck();
            var goose = new GooseAdapter(new Goose());

            Console.WriteLine("\n--- Duck simulator ---\n");

            Simulate(mallardDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(goose);
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}