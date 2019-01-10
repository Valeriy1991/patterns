namespace _02.Observer.Observation.Abstract
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}