using System;
using System.Collections.Generic;
using System.Text;
using _12.CompoundPatterns.Ducks.Observation;

namespace _12.CompoundPatterns.Ducks.Abstract
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
