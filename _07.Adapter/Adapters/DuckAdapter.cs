using _07.Adapter.Ducks;
using _07.Adapter.Turkeys;

namespace _07.Adapter.Adapters
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }
        
        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            // NOTE: как решить проблему, что утки летают дальше, чем индюшки?
            _duck.Fly();
        }
    }
}