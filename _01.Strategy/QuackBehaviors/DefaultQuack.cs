using System;
using _01.Strategy.Abstract;

namespace _01.Strategy.QuackBehaviors
{
    public class DefaultQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}