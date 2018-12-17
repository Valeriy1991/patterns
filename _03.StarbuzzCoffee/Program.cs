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
            Console.WriteLine(beverage1);
            
            Beverage beverage1Small = new Espresso();
            beverage1Small.SetSize(CupSize.Small);
            Console.WriteLine(beverage1Small);
            
            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2);
            
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3);
            
            Beverage beverage3Big = new HouseBlend(CupSize.Big);
            beverage3Big = new Soy(beverage3Big);
            beverage3Big = new Mocha(beverage3Big);
            beverage3Big = new Whip(beverage3Big);
            Console.WriteLine(beverage3Big);
        }
    }
}