using System;
using _01.Strategy.Abstract;
using _01.Strategy.FlyBehaviors;
using _01.Strategy.QuackBehaviors;

namespace _01.Strategy.Ducks
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