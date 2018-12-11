using System;
using _01.WelcomeToPatterns.Abstract;

namespace _01.WelcomeToPatterns.FlyBehaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}