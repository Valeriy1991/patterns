using System;
using _01.WelcomeToPatterns.Abstract;

namespace _01.WelcomeToPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.ReadKey();
        }
    }
}