using System;

namespace _08.TemplateMethod.Beverages
{
    public class Tea : CaffeineBeverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }

        public void AddLemon()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}