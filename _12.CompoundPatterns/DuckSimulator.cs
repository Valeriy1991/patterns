using System;
using _12.CompoundPatterns.Ducks;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Decorators;
using _12.CompoundPatterns.Ducks.Factories;
using _12.CompoundPatterns.Ducks.Observation;
using _12.CompoundPatterns.Geese;
using _12.CompoundPatterns.Geese.Factories;

namespace _12.CompoundPatterns
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory, AbstractGooseAdapterFactory gooseAdapterFactory)
        {
            var redheadDuck = duckFactory.CreateRedheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
            var goose = gooseAdapterFactory.CreateGooseAdapter();

            var ducksFlock = new DuckFlock();
            ducksFlock.Add(redheadDuck);
            ducksFlock.Add(duckCall);
            ducksFlock.Add(rubberDuck);
            ducksFlock.Add(goose);
            
            var mallardDuck1 = duckFactory.CreateMallardDuck();
            var mallardDuck2 = duckFactory.CreateMallardDuck();
            var mallardDuck3 = duckFactory.CreateMallardDuck();
            var mallardDuck4 = duckFactory.CreateMallardDuck();
            var mallardDucksFlock = new DuckFlock();
            mallardDucksFlock.Add(mallardDuck1);
            mallardDucksFlock.Add(mallardDuck2);
            mallardDucksFlock.Add(mallardDuck3);
            mallardDucksFlock.Add(mallardDuck4);
            
            ducksFlock.Add(mallardDucksFlock);

            Console.WriteLine("\n--- Duck simulator ---\n");
            
//            Console.WriteLine("\n---- Duck simulator: Whole Flock simulation\n");
//            Simulate(ducksFlock);
//            
//            Console.WriteLine("\n---- Duck simulator: Whole Flock simulation\n");
//            Simulate(mallardDucksFlock);
            
//            Console.WriteLine($"The ducks quacked {QuackCounterDecorator.AllQuacksCount} times");

            Console.WriteLine("\n---- Duck simulator: with observer\n");
            var quackologist = new Quackologist();
            ducksFlock.RegisterObserver(quackologist);
            Simulate(ducksFlock);
            
            Console.WriteLine($"The ducks quacked {QuackCounterDecorator.AllQuacksCount} times");
        }

        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}