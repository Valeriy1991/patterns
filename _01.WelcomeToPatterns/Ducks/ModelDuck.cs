using System;
using _01.WelcomeToPatterns.Abstract;
using _01.WelcomeToPatterns.FlyBehaviors;
using _01.WelcomeToPatterns.QuackBehaviors;

namespace _01.WelcomeToPatterns.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck() : base(new FlyNoWay(), new DefaultQuack())
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}