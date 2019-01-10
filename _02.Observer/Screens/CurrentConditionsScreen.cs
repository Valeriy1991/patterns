using System;
using _02.Observer.Observation.Abstract;
using _02.Observer.Screens.Abstract;

namespace _02.Observer.Screens
{
    public class CurrentConditionsScreen : IObserver, IScreen
    {
        private float _temp;
        private float _humidity;
        private readonly ISubject _weatherDataSubject;

        public CurrentConditionsScreen(ISubject weatherDataSubject)
        {
            _weatherDataSubject = weatherDataSubject;
            _weatherDataSubject.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temp} F degrees and {_humidity}% humidity");
        }
    }
}