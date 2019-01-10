using _03.Decorator.Abstract;

namespace _03.Decorator.Beverages
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