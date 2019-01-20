using System.Collections.Generic;

namespace _12.CompoundPatterns.Ducks.Observation
{
    public class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            using (var enumerator = _observers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var observer = enumerator.Current;
                    observer.Update(_duck);
                }
            }
        }
    }
}