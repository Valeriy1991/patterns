using _07.Adapter.Ducks;
using _07.Adapter.Turkeys;

namespace _07.Adapter.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;
        
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        
        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            // Индюшка не умеет летать на дальние расстояния, поэтому заставляем
            // ее лететь 5 раз (чтобы привести в соответствие с IDuck) 
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}