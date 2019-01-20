using System;

namespace _12.CompoundPatterns.Ducks.Observation
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} just quacked");
        }
    }
}