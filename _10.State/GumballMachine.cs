using System;
using System.Runtime.CompilerServices;
using System.Text;
using _10.State.States;
using _10.State.States.Abstract;

[assembly:InternalsVisibleTo("_10.State.Tests")]
namespace _10.State
{
    public class GumballMachine
    {
        private readonly IState _soldOutState;
        private readonly IState _noQuarterState;
        private readonly IState _hasQuarterState;
        private readonly IState _soldState;
        private readonly IState _winnerState;

        internal IState State { get; private set; }
        private int _count = 0;

        public GumballMachine(int count)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _winnerState = new WinnerState(this);
            
            _count = count;
            if (count > 0)
            {
                State = _noQuarterState;
            }
            else
            {
                State = _soldOutState;
            }
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        internal void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count > 0)
            {
                _count = _count - 1;
            }
        }
        
        public void Refill(int numGumBalls)
        {
            _count = numGumBalls;
            State = _noQuarterState;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004\n");
            result.Append($"Inventory: {_count.ToString()} gumball");
            if (_count != 1)
            {
                result.Append("s");
            }

            result.Append("\nMachine is ");
            if (State == _soldOutState)
            {
                result.Append("sold out");
            }
            else if (State == _noQuarterState)
            {
                result.Append("waiting for quarter");
            }
            else if (State == _hasQuarterState)
            {
                result.Append("waiting for turn of crank");
            }
            else if (State == _soldState)
            {
                result.Append("delivering a gumball");
            }

            result.Append("\n");
            return result.ToString();
        }

        internal void SetState(IState state)
        {
            State = state;
        }

        internal IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        internal IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        internal IState GetSoldOutState()
        {
            return _soldOutState;
        }

        internal IState GetSoldState()
        {
            return _soldState;
        }

        internal IState GetWinnerState()
        {
            return _winnerState;
        }

        internal int GetCount()
        {
            return _count;
        }
    }
}