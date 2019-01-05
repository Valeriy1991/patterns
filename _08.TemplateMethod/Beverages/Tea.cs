using System;
using _08.TemplateMethod.Beverages.Abstract;

namespace _08.TemplateMethod.Beverages
{
    public class Tea : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}