namespace _12.CompoundPatterns.Ducks.Observation
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}