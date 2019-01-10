using System;
using _01.WelcomeToPatterns.Abstract;

namespace _01.WelcomeToPatterns.FlyBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}