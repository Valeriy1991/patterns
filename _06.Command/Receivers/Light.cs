using System;

namespace _06.Command.Receivers
{
    public class Light
    {
        private readonly string _room;

        public Light(string room)
        {
            _room = room;
        }

        public void On()
        {
            Console.WriteLine($"{_room}: Lights is On");
        }

        public void Off()
        {
            Console.WriteLine($"{_room} Lights is Off");
        }
    }
}