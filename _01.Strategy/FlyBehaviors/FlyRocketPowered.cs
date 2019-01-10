using System;
using _01.Strategy.Abstract;

namespace _01.Strategy.FlyBehaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}