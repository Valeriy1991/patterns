namespace _12.CompoundPatterns.Ducks.Observation
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}