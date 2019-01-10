using _03.StarbuzzCoffee.Abstract;

namespace _03.StarbuzzCoffee.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        
        public override double GetCost()
        {
            return 1.05;
        }
    }
}