using System;
using _07.Facade.Components;

namespace _07.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var amplifier = new Amplifier();
            var tuner = new Tuner();
            var dvdPlayer = new DvdPlayer();
            var cdPlayer = new CdPlayer();
            var projector = new Projector();
            var theaterLights = new TheaterLights();
            var screen = new Screen();
            var popper = new PopcornPopper();
            
            var homeTheater = new HomeTheaterFacade(amplifier, tuner, dvdPlayer, cdPlayer, projector, theaterLights, screen, popper);
            
            homeTheater.WatchMovie("Aquaman");
            homeTheater.EndMovie();
        }
    }
}