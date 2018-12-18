using _04.Pizzeria.Factories;
using _04.Pizzeria.Pizzas;

namespace _04.Pizzeria.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
        
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(_pizzaIngredientFactory);
                pizza.SetName("Chicago style cheese pizza");
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(_pizzaIngredientFactory);
                pizza.SetName("Chicago style pepperoni pizza");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(_pizzaIngredientFactory);
                pizza.SetName("Chicago style clam pizza");
            }
                
            return pizza;
        }
    }
}