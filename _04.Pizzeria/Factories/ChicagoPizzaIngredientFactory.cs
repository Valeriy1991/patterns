using _04.Pizzeria.Ingredients.Cheeses;
using _04.Pizzeria.Ingredients.Clams;
using _04.Pizzeria.Ingredients.Doughs;
using _04.Pizzeria.Ingredients.Pepperonies;
using _04.Pizzeria.Ingredients.Sauces;
using _04.Pizzeria.Ingredients.Veggies;

namespace _04.Pizzeria.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            return new Mozzarella();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[]
            {
                new EggPlant(),
                new BlackOlives(),
                new Spinach()
            };
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}