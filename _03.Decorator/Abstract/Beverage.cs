using System.Globalization;

namespace _03.StarbuzzCoffee.Abstract
{
    public abstract class Beverage
    {
        protected string Description = "Unknown beverage";
        protected CupSize CupSize;
        
        public virtual string GetDescription()
        {
            return $"{Description} ({GetSize()})";
        }

        public abstract double GetCost();

        public void SetSize(CupSize cupSize)
        {
            CupSize = cupSize;
        }

        public CupSize GetSize()
        {
            return CupSize;
        }

        public override string ToString()
        {
            return $"{GetDescription()} - ${GetCost().ToString(CultureInfo.InvariantCulture)}";
        }
    }
}