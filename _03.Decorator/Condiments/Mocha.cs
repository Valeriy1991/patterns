using _03.Decorator.Abstract;

namespace _03.Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Mocha";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 0.20;
        }
    }
}