using _04.Pizzeria.Factories;
using _04.Pizzeria.Pizzas;

namespace _04.Pizzeria
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _simplePizzaFactory;

        public PizzaStore(SimplePizzaFactory simplePizzaFactory)
        {
            _simplePizzaFactory = simplePizzaFactory;
        }

        public Pizza CreateOrder(string type)
        {
            var pizza = _simplePizzaFactory.Create(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}