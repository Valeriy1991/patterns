using System;
using System.Collections.Generic;
using _02.WeatherStation.Observation.Abstract;

namespace _02.WeatherStation.Observation
{
    public class WeatherDataSubject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private float _temp;
        private float _humidity;
        private float _pressure;
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temp, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
    }
}