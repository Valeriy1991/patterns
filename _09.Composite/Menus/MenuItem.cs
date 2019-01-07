using System;
using System.Text;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Menus
{
    public class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegetarian;
        private readonly decimal _price;

        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            _name = name;
            _description = description;
            _isVegetarian = isVegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }
        
        public override string GetDescription()
        {
            return _description;
        }

        public override decimal GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _isVegetarian;
        }

        public override void Print()
        {
            var messageBuilder = new StringBuilder();
            messageBuilder.Append($"  {GetName()}");
            if (IsVegetarian())
            {
                messageBuilder.Append(" (v)");
            }

            messageBuilder.Append($", {GetPrice()}");
            messageBuilder.Append($"\n   -- {GetDescription()}");
            
            Console.WriteLine(messageBuilder);
        }
    }
}