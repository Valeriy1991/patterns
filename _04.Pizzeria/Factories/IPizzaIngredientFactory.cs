using _04.Pizzeria.Ingredients.Cheeses;
using _04.Pizzeria.Ingredients.Clams;
using _04.Pizzeria.Ingredients.Doughs;
using _04.Pizzeria.Ingredients.Pepperonies;
using _04.Pizzeria.Ingredients.Sauces;
using _04.Pizzeria.Ingredients.Veggies;

namespace _04.Pizzeria.Factories
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggie[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}