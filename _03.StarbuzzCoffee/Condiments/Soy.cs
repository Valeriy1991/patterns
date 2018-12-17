using _03.StarbuzzCoffee.Abstract;

namespace _03.StarbuzzCoffee.Condiments
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
            return _beverage.GetCost() + 0.15;
        }
    }
}