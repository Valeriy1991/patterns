using System;
using _01.Strategy.Abstract;

namespace _01.Strategy.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}