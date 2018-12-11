using System;
using _01.WelcomeToPatterns.Abstract;
using _01.WelcomeToPatterns.FlyBehaviors;
using _01.WelcomeToPatterns.QuackBehaviors;

namespace _01.WelcomeToPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new FlyWithWings(), new DefaultQuack())
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}