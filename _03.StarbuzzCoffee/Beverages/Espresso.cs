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
            return 1.99;
        }
    }
}