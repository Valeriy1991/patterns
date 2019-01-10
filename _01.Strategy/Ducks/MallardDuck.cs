using System;
using _01.Strategy.Abstract;
using _01.Strategy.FlyBehaviors;
using _01.Strategy.QuackBehaviors;

namespace _01.Strategy.Ducks
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