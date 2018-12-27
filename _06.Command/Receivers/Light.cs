using System;

namespace _06.Command.Receivers
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Lights is On");
        }

        public void Off()
        {
            Console.WriteLine("Lights is Off");
        }
    }
}