using System;

namespace _07.Facade.Components
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn Popper: on");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper: pop");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn Popper: off");
        }
    }
}