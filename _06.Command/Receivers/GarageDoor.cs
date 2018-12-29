using System;

namespace _06.Command.Receivers
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage: door is up");
        }
        public void LightOn()
        {
            Console.WriteLine("Garage: light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage: light is off");
        }

        public void Down()
        {
            Console.WriteLine("Garage: door is down");
        }
    }
}