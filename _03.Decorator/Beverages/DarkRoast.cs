using _03.Decorator.Abstract;

namespace _03.Decorator.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public DarkRoast(CupSize cupSize)
        {
            SetSize(cupSize);
        }
        
        public override double GetCost()
        {
            return 0.99;
        }
    }
}