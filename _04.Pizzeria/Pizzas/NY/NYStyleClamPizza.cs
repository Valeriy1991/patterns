using System;

namespace _04.Pizzeria.Pizzas.NY
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY style clam pizza";
            Dough = "Thin crust dough";
            Sauce = "Plum tomato sauce";
            
            Toppings.Add("Shredded mozzarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}