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
            //TrySimpleRemoteControl();
            //TryRemoteControl();
            //TryRemoteControlWithUndoing();
            TryRemoteControlWithUndoingForCeilingFan();
            TryRemoteControlWithMacroCommand();
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

        static void TryRemoteControlWithUndoing()
        {
            Console.WriteLine("\n----- Remote control with Undo -----\n");

            var remoteControl = new RemoteControl();

            var livingRoomLight = new Light("Living room");
            var livingRoomLightOn = new LightsOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightsOffCommand(livingRoomLight);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();

            Console.WriteLine();

            remoteControl.PressOffButton(0);
            remoteControl.PressOnButton(0);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();
        }

        static void TryRemoteControlWithUndoingForCeilingFan()
        {
            Console.WriteLine("\n----- Remote control with Undo for ceiling fan -----\n");

            var remoteControl = new RemoteControl();

            var ceilingFan = new CeilingFan("Living room");

            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remoteControl.PressOnButton(0);
            remoteControl.PressOffButton(0);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();

            Console.WriteLine();

            remoteControl.PressOnButton(1);
            Console.WriteLine(remoteControl);
            remoteControl.PressUndoButton();
        }

        static void TryRemoteControlWithMacroCommand()
        {
            Console.WriteLine("\n----- Remote control with party! -----\n");

            var remoteControl = new RemoteControl();

            var light = new Light("Living room");
            var stereo = new Stereo("Living room");

            var lightOn = new LightsOnCommand(light);
            var lightOff = new LightsOffCommand(light);
            var stereoOn = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffWithCDCommand(stereo);

            var partyOn = new ICommand[] {lightOn, stereoOn};
            var partyOff = new ICommand[] { lightOff, stereoOff };

            var partyOnCommand = new MacroCommand(partyOn);
            var partyOffCommand = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyOnCommand, partyOffCommand);
            Console.WriteLine(remoteControl);

            Console.WriteLine("\n-- Party on --\n");
            remoteControl.PressOnButton(0);
            Console.WriteLine("\n-- Party off --\n");
            remoteControl.PressOffButton(0);
        }
    }
}
