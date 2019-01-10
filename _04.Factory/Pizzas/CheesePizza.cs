using System;
using _04.Factory.Factories;

namespace _04.Factory.Pizzas
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
        }
    }
}