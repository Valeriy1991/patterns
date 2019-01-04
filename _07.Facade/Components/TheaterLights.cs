using System;

namespace _07.Facade.Components
{
    public class TheaterLights
    {
        public void Dim(int dim)
        {
            Console.WriteLine($"Theater lights: set dim {dim}");
            
        }

        public void On()
        {
            Console.WriteLine("Theater lights: on");
        }
    }
}