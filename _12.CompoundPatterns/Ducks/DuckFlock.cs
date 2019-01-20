using System.Collections.Generic;
using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Ducks
{
    /// <summary>
    /// Утиная стая
    /// </summary>
    public class DuckFlock : IQuackable
    {
        private readonly List<IQuackable> _quackers = new List<IQuackable>();
        
        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }
        
        public void Quack()
        {
            using (var enumerator = _quackers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var quacker = enumerator.Current;
                    quacker.Quack();
                }
            }
        }
    }
}