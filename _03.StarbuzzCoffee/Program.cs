using System;
using _03.StarbuzzCoffee.Abstract;
using _03.StarbuzzCoffee.Beverages;
using _03.StarbuzzCoffee.Condiments;

namespace _03.StarbuzzCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();
//            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.GetCost());
            Console.WriteLine(beverage1);
            
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
//            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.GetCost());
            Console.WriteLine(beverage2);
            
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
//            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.GetCost());
            Console.WriteLine(beverage3);

            Console.ReadKey();
        }
    }
}