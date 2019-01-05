using System;
using _08.TemplateMethod.Beverages.Abstract;

namespace _08.TemplateMethod.Beverages
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}