using System;
using _06.Command.Commands.Abstract;
using _06.Command.Receivers;

namespace _06.Command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
            _garageDoor.LightOn();

            Console.WriteLine("Garage door is open");
        }

        public void Undo()
        {
            _garageDoor.LightOff();
            _garageDoor.Down();
        }
    }
}