using System;

namespace _07.Facade.Components
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier: on");
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Amplifier: set DVD-player");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier: set Surround Sound");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Amplifier: set volume {volume}");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier: off");
        }
    }
}