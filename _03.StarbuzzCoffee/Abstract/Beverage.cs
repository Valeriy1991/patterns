using System.Globalization;

namespace _03.StarbuzzCoffee.Abstract
{
    public abstract class Beverage
    {
        protected string Description = "Unknown beverage";
        
        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double GetCost();

        public override string ToString()
        {
            return $"{GetDescription()} - ${GetCost().ToString()}";
        }
    }
}