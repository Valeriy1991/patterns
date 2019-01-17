using System;
using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Ducks
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}