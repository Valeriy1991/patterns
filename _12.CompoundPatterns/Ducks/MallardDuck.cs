using System;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Observation;

namespace _12.CompoundPatterns.Ducks
{
    public class MallardDuck : IQuackable
    {
        private readonly Observable _observable;

        public MallardDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Mallard Duck";
        }
    }
}