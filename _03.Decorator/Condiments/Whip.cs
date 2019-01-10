using _03.Decorator.Abstract;

namespace _03.Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Whip";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 0.10;
        }
    }
}