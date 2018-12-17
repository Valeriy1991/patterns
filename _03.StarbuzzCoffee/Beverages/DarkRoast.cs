using _03.StarbuzzCoffee.Abstract;

namespace _03.StarbuzzCoffee.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }
        
        public override double GetCost()
        {
            return 0.99;
        }
    }
}