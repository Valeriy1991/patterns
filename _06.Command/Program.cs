using System;
using _06.Command.Commands;
using _06.Command.Commands.Abstract;
using _06.Command.Invokers;
using _06.Command.Receivers;

namespace _06.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleRemoteControl = new SimpleRemoteControl();

            var light = new Light();
            var lightsOnCommand = new LightsOnCommand(light);

            simpleRemoteControl.SetCommand(lightsOnCommand);
            simpleRemoteControl.PressTheButton();

            var garageDoor = new GarageDoor();
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            simpleRemoteControl.SetCommand(garageDoorOpenCommand);
            simpleRemoteControl.PressTheButton();
        }
    }
}
