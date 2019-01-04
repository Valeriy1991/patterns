using System;

namespace _07.Facade.Components
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD-player: on");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"DVD-player: play movie \"{movie}\"");
        }

        public void Stop()
        {
            Console.WriteLine("DVD-player: stop");
        }

        public void Eject()
        {
            Console.WriteLine("DVD-player: eject");
        }

        public void Off()
        {
            Console.WriteLine("DVD-player: off");
        }
    }
}