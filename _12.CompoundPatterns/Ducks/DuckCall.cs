using System;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Observation;

namespace _12.CompoundPatterns.Ducks
{
    public class DuckCall : IQuackable
    {
        private readonly Observable _observable;

        public DuckCall()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
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
            return "Duck Call";
        }
    }
}