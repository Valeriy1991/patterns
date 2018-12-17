namespace _04.Pizzeria.Pizzas.NY
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Name = "NY style sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara sauce";
            
            Toppings.Add("Grated reggiano cheese");
        }
    }
}