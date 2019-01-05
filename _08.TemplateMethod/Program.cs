using System;
using _08.TemplateMethod.Beverages;

namespace _08.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Tea ---");
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("\n--- Coffee ---");
            var coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine("\n--- Tea (with hook)---");
            var teaWithHook = new TeaWithHook();
            teaWithHook.PrepareRecipe();
            
            Console.WriteLine("\n--- Coffee (with hook) ---");
            var coffeeWithHook = new CoffeeWithHook();
            coffeeWithHook.PrepareRecipe();
            
        }
    }
}