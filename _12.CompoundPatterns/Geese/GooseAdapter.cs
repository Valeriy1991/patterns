using _12.CompoundPatterns.Ducks.Abstract;
using _12.CompoundPatterns.Ducks.Observation;

namespace _12.CompoundPatterns.Geese
{
    public class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;
        private readonly Observable _observable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void Quack()
        {
            _goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Goose pretending to be a Duck";
        }
    }
}