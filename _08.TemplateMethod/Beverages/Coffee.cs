using System;

namespace _08.TemplateMethod.Beverages
{
    public class Coffee : CaffeineBeverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        public void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public void AddSugarAndMilk()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}