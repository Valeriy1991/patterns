using System;
using _01.WelcomeToPatterns.Abstract;

namespace _01.WelcomeToPatterns.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}