using System;

namespace _08.TemplateMethod.Beverages
{
    public abstract class CaffeineBeverage
    {
        public abstract void PrepareRecipe();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}