using System;
using _08.TemplateMethod.Beverages.Abstract;

namespace _08.TemplateMethod.Beverages
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}