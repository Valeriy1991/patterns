using System;
using _08.TemplateMethod.Beverages.Abstract;

namespace _08.TemplateMethod.Beverages
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
        
        protected override bool CustomerWantsCondiments()
        {
            string answer = GetUserAnswer();
            return answer.Equals("y", StringComparison.OrdinalIgnoreCase);
        }

        private string GetUserAnswer()
        {
            Console.WriteLine("Would you like lemon with your tea? (y/n)");
            var answer = Console.ReadLine();
            return answer;
        }
    }
}