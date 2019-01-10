using _04.Factory.Ingredients.Cheeses;
using _04.Factory.Ingredients.Clams;
using _04.Factory.Ingredients.Doughs;
using _04.Factory.Ingredients.Pepperonies;
using _04.Factory.Ingredients.Sauces;
using _04.Factory.Ingredients.Veggies;

namespace _04.Factory.Factories
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