using _04.Pizzeria.Factories;
using _04.Pizzeria.Pizzas;
using _04.Pizzeria.Pizzas.NY;

namespace _04.Pizzeria.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new NyStyleCheesePizza();
            if (type.Equals("pepperoni"))
                return new NyStylePepperoniPizza();
            if (type.Equals("clam"))
                return new NYStyleClamPizza();
                
            return null;
        }
    }
}