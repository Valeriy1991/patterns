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
            var gumbalMachine = new GumballMachine(5);

            Console.WriteLine(gumbalMachine);

            gumbalMachine.InsertQuarter();
            gumbalMachine.TurnCrank();

            Console.WriteLine(gumbalMachine);

            gumbalMachine.InsertQuarter();
            gumbalMachine.EjectQuarter();
            gumbalMachine.TurnCrank();

            Console.WriteLine(gumbalMachine);

            gumbalMachine.InsertQuarter();
            gumbalMachine.TurnCrank();
            gumbalMachine.InsertQuarter();
            gumbalMachine.TurnCrank();
            gumbalMachine.EjectQuarter();

            Console.WriteLine(gumbalMachine);

            gumbalMachine.InsertQuarter();
            gumbalMachine.InsertQuarter();
            gumbalMachine.TurnCrank();
            gumbalMachine.InsertQuarter();
            gumbalMachine.TurnCrank();
            gumbalMachine.InsertQuarter();
            gumbalMachine.TurnCrank();

            Console.WriteLine(gumbalMachine);
        }
    }
}
