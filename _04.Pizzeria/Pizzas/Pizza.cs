using System;
using System.Collections.Generic;

namespace _04.Pizzeria.Pizzas
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> Toppings { get; } = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing sauce...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < Toppings.Count; i++)
            {
                Console.WriteLine($"  {Toppings[i]}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}