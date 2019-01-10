using System;
using _03.Decorator.Abstract;

namespace _03.Decorator.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy";
        }

        public override double GetCost()
        {
            var size = _beverage.GetSize();
            switch (size)
            {
                case CupSize.Small:
                    return _beverage.GetCost() + 0.10;
                case CupSize.Middle:
                    return _beverage.GetCost() + 0.15;
                case CupSize.Big:
                    return _beverage.GetCost() + 0.20;
            }
            throw new ArgumentException(nameof(CupSize));
        }
    }
}