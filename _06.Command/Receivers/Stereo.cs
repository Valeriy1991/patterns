using System;

namespace _06.Command.Receivers
{
    public class Stereo
    {
        private readonly string _room;

        public Stereo(string room)
        {
            _room = room;
        }

        public void On()
        {
            Console.WriteLine($"{_room} Stereo is On");
        }
        public void Off()
        {
            Console.WriteLine($"{_room} Stereo is Off");
        }

        public void SetCD()
        {
            Console.WriteLine($"{_room} Stereo - set CD");
        }

        public void SetDVD()
        {
            Console.WriteLine($"{_room} Stereo - set DVD");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_room} Stereo - set Radio mode");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"{_room} Stereo - set volume {volume}");
        }
    }
}