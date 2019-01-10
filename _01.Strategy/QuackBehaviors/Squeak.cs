using System;
using _01.Strategy.Abstract;

namespace _01.Strategy.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}