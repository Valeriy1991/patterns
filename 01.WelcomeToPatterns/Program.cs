using System;
using _01.WelcomeToPatterns.Abstract;
using _01.WelcomeToPatterns.Ducks;
using _01.WelcomeToPatterns.FlyBehaviors;

namespace _01.WelcomeToPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine("===");

            Duck model = new ModelDuck();
            model.Display();
            mallard.PerformQuack();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadKey();
        }
    }
}