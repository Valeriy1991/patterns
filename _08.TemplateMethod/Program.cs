using System;
using _08.TemplateMethod.Beverages;

namespace _08.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("\n-------");
            
            var coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}