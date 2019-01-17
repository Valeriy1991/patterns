using System;
using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Ducks
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}