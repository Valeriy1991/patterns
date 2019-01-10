namespace _02.WeatherStation.Observation.Abstract
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}