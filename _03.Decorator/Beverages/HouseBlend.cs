using _03.Decorator.Abstract;

namespace _03.Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffee";
        }

        public HouseBlend(CupSize cupSize) : this()
        {
            SetSize(cupSize);
        }
        
        public override double GetCost()
        {
            return 0.89;
        }
    }
}