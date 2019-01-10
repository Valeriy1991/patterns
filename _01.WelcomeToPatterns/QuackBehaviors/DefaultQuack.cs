using System;
using _01.WelcomeToPatterns.Abstract;

namespace _01.WelcomeToPatterns.QuackBehaviors
{
    public class DefaultQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}