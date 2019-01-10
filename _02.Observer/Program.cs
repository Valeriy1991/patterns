using System;
using _02.Observer.Observation;
using _02.Observer.Screens;

namespace _02.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherDataSubject = new WeatherDataSubject();

            CurrentConditionsScreen currentScreen = new CurrentConditionsScreen(weatherDataSubject);
            //StatisticsScreen statisticsScreen = new StatisticsScreen(weatherDataSubject);
            //ForecastScreen forecastScreen = new ForecastScreen(weatherDataSubject);
            
            weatherDataSubject.SetMeasurements(80, 65, 30.4f);
            weatherDataSubject.SetMeasurements(82, 70, 29.2f);
            weatherDataSubject.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
