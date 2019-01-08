using System;
using System.Collections.Generic;
using _09.Composite.Menus;
using _09.Composite.Menus.Abstract;

namespace _09.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/bethrobson/Head-First-Design-Patterns/blob/master/src/headfirst/designpatterns/composite/menu/MenuTestDrive.java
            var pancakeHouseMenu = CreatePancakeHouseMenu();
            var dinerMenu = CreateDinerMenu();
            var cafeMenu = CreateCafeMenu();
            
            var menu = new Menu("ALL MENU", "All menus combined");
            menu.Add(pancakeHouseMenu);
            menu.Add(dinerMenu);
            menu.Add(cafeMenu);
            
            var waitress = new Waitress(menu);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();
        }

        static Menu CreatePancakeHouseMenu()
        {
            var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            pancakeHouseMenu.Add(new MenuItem(
                "K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99M));
            pancakeHouseMenu.Add(new MenuItem(
                "Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99M));
            pancakeHouseMenu.Add(new MenuItem(
                "Blueberry Pancakes",
                "Pancakes made with fresh blueberries, and blueberry syrup",
                true,
                3.49M));
            pancakeHouseMenu.Add(new MenuItem(
                "Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59M));
            return pancakeHouseMenu;
        }

        static Menu CreateDinerMenu()
        {
            var dinerMenu = new Menu("DINER MENU", "Lunch");
            dinerMenu.Add(new MenuItem(
                "Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", 
                true, 
                2.99M));
            dinerMenu.Add(new MenuItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat", 
                false, 
                2.99M));
            dinerMenu.Add(new MenuItem(
                "Soup of the day",
                "A bowl of the soup of the day, with a side of potato salad", 
                false, 
                3.29M));
            dinerMenu.Add(new MenuItem(
                "Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 
                3.05M));
            dinerMenu.Add(new MenuItem(
                "Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice", 
                true, 
                3.99M));
            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 
                3.89M));

            var dessertMenu = CreateDessertMenu();
            dinerMenu.Add(dessertMenu);

            return dinerMenu;
        }

        static Menu CreateDessertMenu()
        {
            var dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
            dessertMenu.Add(new MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true,
                1.59M));
  
            dessertMenu.Add(new MenuItem(
                "Cheesecake",
                "Creamy New York cheesecake, with a chocolate graham crust",
                true,
                1.99M));
            dessertMenu.Add(new MenuItem(
                "Sorbet",
                "A scoop of raspberry and a scoop of lime",
                true,
                1.89M));

            return dessertMenu;
        }

        static Menu CreateCafeMenu()
        {
            var cafeMenu = new Menu("CAFE MENU", "Dinner");
            cafeMenu.Add(new MenuItem(
                "Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 
                3.99M));
            cafeMenu.Add(new MenuItem(
                "Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 
                3.69M));
            cafeMenu.Add(new MenuItem(
                "Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 
                4.29M));

            var coffeeMenu = CreateCoffeeMenu();
            cafeMenu.Add(coffeeMenu);

            return cafeMenu;
        }

        static Menu CreateCoffeeMenu()
        {
            var coffeeMenu = new Menu("COFFEE MENU", "Stuff to go with your afternoon coffee");
            coffeeMenu.Add(new MenuItem(
                "Coffee Cake",
                "Crumbly cake topped with cinnamon and walnuts",
                true,
                1.59M));
            coffeeMenu.Add(new MenuItem(
                "Bagel",
                "Flavors include sesame, poppyseed, cinnamon raisin, pumpkin",
                false,
                0.69M));
            coffeeMenu.Add(new MenuItem(
                "Biscotti",
                "Three almond or hazelnut biscotti cookies",
                true,
                0.89M));
            return coffeeMenu;
        }
    }
}