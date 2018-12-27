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
            TrySimpleRemoteControl();
            TryRemoteControl();
        }

        static void TrySimpleRemoteControl()
        {
            Console.WriteLine("\n----- Simple remote control -----\n");

            var simpleRemoteControl = new SimpleRemoteControl();

            var light = new Light("Living room");
            var lightsOnCommand = new LightsOnCommand(light);

            simpleRemoteControl.SetCommand(lightsOnCommand);
            simpleRemoteControl.PressTheButton();

            var garageDoor = new GarageDoor();
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            simpleRemoteControl.SetCommand(garageDoorOpenCommand);
            simpleRemoteControl.PressTheButton();
        }

        static void TryRemoteControl()
        {
            var remoteControl = new RemoteControl();

            var livingRoomLight = new Light("Living room");
            var kitchenLight = new Light("Kitchen");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo("Living room");

            var livingRoomLightOnCommand = new LightsOnCommand(livingRoomLight);
            var livingRoomLightOffCommand = new LightsOffCommand(livingRoomLight);
            var kitchenLightOnCommand = new LightsOnCommand(kitchenLight);
            var kitchenLightOffCommand = new LightsOffCommand(kitchenLight);

            remoteControl.SetCommand(0, livingRoomLightOnCommand, livingRoomLightOffCommand);
            remoteControl.SetCommand(1, kitchenLightOnCommand, kitchenLightOffCommand);

            Console.WriteLine(remoteControl);

            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);

            remoteControl.PressOnButton(1);
            remoteControl.PressOffButton(1);
        }
    }
}
