using _07.Facade.Components;

namespace _07.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly Tuner _tuner;
        private readonly DvdPlayer _dvdPlayer;
        private readonly CdPlayer _cdPlayer;
        private readonly Projector _projector;
        private readonly TheaterLights _theaterLights;
        private readonly Screen _screen;
        private readonly PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer,
            Projector projector, TheaterLights theaterLights, Screen screen, PopcornPopper popper)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _theaterLights = theaterLights;
            _screen = screen;
            _popper = popper;
        }
    }
}