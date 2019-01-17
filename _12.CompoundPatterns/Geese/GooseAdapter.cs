using _12.CompoundPatterns.Ducks.Abstract;

namespace _12.CompoundPatterns.Geese
{
    public class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
        }
    }
}