using System;
using _03.Decorator.Abstract;

namespace _03.Decorator.Beverages
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