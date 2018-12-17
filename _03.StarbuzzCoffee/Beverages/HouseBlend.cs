using _03.StarbuzzCoffee.Abstract;

namespace _03.StarbuzzCoffee.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend coffee";
        }
        
        public override double GetCost()
        {
            return 0.89;
        }
    }
}