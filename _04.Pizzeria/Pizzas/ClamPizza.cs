using System;
using _04.Pizzeria.Factories;

namespace _04.Pizzeria.Pizzas
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        
        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Clams = _pizzaIngredientFactory.CreateClams();
        }
    }
}