using System;
using _01.Strategy.Abstract;
using _01.Strategy.Ducks;
using _01.Strategy.FlyBehaviors;

namespace _01.Strategy
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