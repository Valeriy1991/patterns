using System;
using _10.State.States.Abstract;

namespace _10.State.States
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _machine;
        
        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }
        
        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _machine.SetState(_machine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}