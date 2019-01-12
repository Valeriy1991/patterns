using System;

namespace _10.State
{
    class Program
    {
        static void Main(string[] args)
        {
            TryGumballMachine();
        }

        static void TryGumballMachine()
        {
            var gumballMachine = new GumballMachine(10);

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
