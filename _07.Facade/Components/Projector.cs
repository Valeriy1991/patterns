using System;

namespace _07.Facade.Components
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector: on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector: set wide screen mode");
            
        }

        public void Off()
        {
            Console.WriteLine("Projector: off");
        }
    }
}