using System;

namespace _08.TemplateMethod.Beverages.Abstract
{
    public abstract class CaffeineBeverage
    {
        // Шаблонный метод - потому что он служит шаблоном для алгоритма приготовления напитка
        public void PrepareRecipe()
        {
            // Шаблонный метод определяет основные шаги алгоритма и позволяет субклассам предоставить
            // реализацию одного или нескольких шагов
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
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

        protected abstract void AddCondiments();
    }
}