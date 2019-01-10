using _04.Factory.Ingredients.Cheeses;
using _04.Factory.Ingredients.Clams;
using _04.Factory.Ingredients.Doughs;
using _04.Factory.Ingredients.Pepperonies;
using _04.Factory.Ingredients.Sauces;
using _04.Factory.Ingredients.Veggies;

namespace _04.Factory.Factories
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