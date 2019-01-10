using _04.Factory.Factories;
using _04.Factory.Pizzas;

namespace _04.Factory.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory = new NYPizzaIngredientFactory();
        
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(_pizzaIngredientFactory);
                pizza.SetName("New York style cheese pizza");
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(_pizzaIngredientFactory);
                pizza.SetName("New York style pepperoni pizza");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(_pizzaIngredientFactory);
                pizza.SetName("New York style clam pizza");
            }
                
            return pizza;
        }
    }
}