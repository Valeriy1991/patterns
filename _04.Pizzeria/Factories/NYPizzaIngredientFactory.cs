using _04.Pizzeria.Ingredients.Cheeses;
using _04.Pizzeria.Ingredients.Clams;
using _04.Pizzeria.Ingredients.Doughs;
using _04.Pizzeria.Ingredients.Pepperonies;
using _04.Pizzeria.Ingredients.Sauces;
using _04.Pizzeria.Ingredients.Veggies;

namespace _04.Pizzeria.Factories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[]
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}