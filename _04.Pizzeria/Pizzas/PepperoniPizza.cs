using System;
using _04.Pizzeria.Factories;

namespace _04.Pizzeria.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        
        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
        }
    }
}