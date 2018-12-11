using System;

namespace _01.WelcomeToPatterns.Abstract
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior { get; private set; }
        protected IQuackBehavior QuackBehavior { get; private set; }

        protected Duck()
        {

        }
        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
