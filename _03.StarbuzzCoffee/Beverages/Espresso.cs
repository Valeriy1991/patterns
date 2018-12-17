using System;
using _03.StarbuzzCoffee.Abstract;

namespace _03.StarbuzzCoffee.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        
        public override double GetCost()
        {
            switch (CupSize)
            {
                case CupSize.Middle:
                    return 1.99;
                case CupSize.Small:
                    return 1.79;
                case CupSize.Big:
                    return 2.19;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}