using System;

namespace _08.TemplateMethod.Beverages.Abstract
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected abstract void Brew();

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        // Метод-перехватчик - субкласс может его переопределить (если захочет)
        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        protected abstract void AddCondiments();
    }
}