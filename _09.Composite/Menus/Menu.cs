using System;
using System.Collections.Generic;
using _09.Composite.Menus.Abstract;

namespace _09.Composite.Menus
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents;
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
            
            _menuComponents = new List<MenuComponent>();
        }

        public override void Add(MenuComponent component)
        {
            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _menuComponents.Remove(component);
        }

        public override MenuComponent GetChild(int index)
        {
            return _menuComponents[index];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.WriteLine($"\n{GetName()}, {GetDescription()}");
            Console.WriteLine(new string('-', 10));

            using (var enumerator = _menuComponents.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var component = enumerator.Current;
                    component.Print();
                }
            }
        }
    }
}