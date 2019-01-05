using System;
using System.IO;
using _08.TemplateMethod.Beverages.Abstract;

namespace _08.TemplateMethod.Beverages
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserAnswer();
            return answer.Equals("y", StringComparison.OrdinalIgnoreCase);
        }

        private string GetUserAnswer()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee? (y/n)");
            var answer = Console.ReadLine();
            return answer;
        }
    }
}