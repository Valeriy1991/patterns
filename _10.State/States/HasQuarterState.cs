using System;
using _10.State.States.Abstract;

namespace _10.State.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _machine;
        
        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }


        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _machine.SetState(_machine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            _machine.SetState(_machine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}