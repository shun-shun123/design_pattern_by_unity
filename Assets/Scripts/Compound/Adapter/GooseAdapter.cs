using Compound.Animal;
using Compound.Interface;
using UnityEngine;

namespace Compound.Adapter
{

    public class GooseAdapter : IQuackable
    {
        private Goose _goose;

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