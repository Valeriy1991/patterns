using _04.Pizzeria.Factories;
using _04.Pizzeria.Pizzas;

namespace _04.Pizzeria.PizzaStores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}