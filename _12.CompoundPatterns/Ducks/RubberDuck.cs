using System;
using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Ducks
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}