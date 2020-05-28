using Adapter.Interfaces;

namespace Adapter
{
    public class DuckAdapter : ITurkey
    {
        private IDuck _duck;

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
            _duck.Fly();
        }
    }
}