using System;
using _10.State.States.Abstract;

namespace _10.State.States
{
    public class SoldOutState : IState
    {
        private GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}