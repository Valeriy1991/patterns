using System;

namespace _09.Composite.Menus.Abstract
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent component)
        {
            throw new InvalidOperationException();
        }
        public virtual void Remove(MenuComponent component)
        {
            throw new InvalidOperationException();
        }
        public virtual void GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public virtual string GetName()
        {
            throw new InvalidOperationException();
        }
        public virtual string GetDescription()
        {
            throw new InvalidOperationException();
        }
        public virtual decimal GetPrice()
        {
            throw new InvalidOperationException();
        }
        public virtual bool IsVegetarian()
        {
            throw new InvalidOperationException();
        }
        public virtual void Print()
        {
            throw new InvalidOperationException();
        }
    }
}