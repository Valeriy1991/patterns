using System;
using _12.CompoundPatterns.Ducks;
using _12.CompoundPatterns.Ducks.Factories;
using _12.CompoundPatterns.Geese.Factories;

namespace _12.CompoundPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var duckSimulator = new DuckSimulator();
            var duckFactory = new CountingDuckFactory();
            var gooseAdapterFactory = new GooseAdapterFactory();
            
            duckSimulator.Simulate(duckFactory, gooseAdapterFactory);
        }
    }
}
