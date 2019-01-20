using System;
using System.Collections.Generic;
using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Observation;

namespace _12.CompoundPatterns.Ducks
{
    /// <summary>
    /// Утиная стая
    /// </summary>
    public class DuckFlock : IQuackable
    {
        private readonly List<IQuackable> _quackers = new List<IQuackable>();
//        private readonly Observable _observable;
        
        public DuckFlock()
        {
//            _observable = new Observable(this);
        }
        
        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }
        
        public void Quack()
        {
            using (var enumerator = _quackers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var quacker = enumerator.Current;
                    quacker.Quack();
                }
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            using (var enumerator = _quackers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var quacker = enumerator.Current;
                    quacker.RegisterObserver(observer);
                }
            }
//            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
//            using (var enumerator = _quackers.GetEnumerator())
//            {
//                while (enumerator.MoveNext())
//                {
//                    var quacker = enumerator.Current;
//                    quacker.NotifyObservers();
//                }
//            }
//            _observable.NotifyObservers();
            throw new NotImplementedException();
        }
    }
}