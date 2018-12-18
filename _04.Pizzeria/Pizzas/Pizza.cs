using System;
using System.Collections.Generic;
using _04.Pizzeria.Ingredients.Cheeses;
using _04.Pizzeria.Ingredients.Clams;
using _04.Pizzeria.Ingredients.Doughs;
using _04.Pizzeria.Ingredients.Pepperonies;
using _04.Pizzeria.Ingredients.Sauces;
using _04.Pizzeria.Ingredients.Veggies;

namespace _04.Pizzeria.Pizzas
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Cheese Cheese { get; set; }
        protected Veggie[] Veggies { get; set; }
        protected Pepperoni Pepperoni { get; set; }
        protected Clams Clams { get; set; }

        public abstract void Prepare();

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

        public void SetName(string name)
        {
            Name = name;
        }
    }
}