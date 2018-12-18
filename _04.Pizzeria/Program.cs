using System;
using _04.Pizzeria.Pizzas;
using _04.Pizzeria.PizzaStores;

namespace _04.Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}{Environment.NewLine}");
            
            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}{Environment.NewLine}");
            
            
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}{Environment.NewLine}");
            
            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}{Environment.NewLine}");
        }
    }
}