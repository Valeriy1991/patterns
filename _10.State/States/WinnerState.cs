using System;
using _10.State.States.Abstract;

namespace _10.State.States
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _machine;

        public WinnerState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get 2 gumballs for your quarter");
            _machine.ReleaseBall();
            var gumballsCount = _machine.GetCount();
            if (gumballsCount == 0)
            {
                _machine.SetState(_machine.GetSoldOutState());
            }
            else
            {
                _machine.ReleaseBall();
                gumballsCount = _machine.GetCount();
                if (gumballsCount > 0)
                {
                    _machine.SetState(_machine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _machine.SetState(_machine.GetSoldOutState());
                }
            }
        }
    }
}