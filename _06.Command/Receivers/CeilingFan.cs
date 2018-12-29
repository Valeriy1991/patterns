using System;

namespace _06.Command.Receivers
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private string _room;
        private int _speed;

        public CeilingFan(string room)
        {
            _room = room;
            _speed = OFF;
        }

        public void High()
        {
            _speed = HIGH;
            Console.WriteLine($"{_room} ceiling fan is High");
        }

        public void Medium()
        {
            _speed = MEDIUM;
            Console.WriteLine($"{_room} ceiling fan is Medium");
        }
        public void Low()
        {
            _speed = LOW;
            Console.WriteLine($"{_room} ceiling fan is Low");
        }
        public void Off()
        {
            _speed = OFF;
            Console.WriteLine($"{_room} ceiling fan is Off");
        }
        public int GetSpeed() => _speed;
    }
}