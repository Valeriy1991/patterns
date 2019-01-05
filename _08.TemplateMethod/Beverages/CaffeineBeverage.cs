using System;

namespace _08.TemplateMethod.Beverages
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

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract void AddCondiments();
    }
}