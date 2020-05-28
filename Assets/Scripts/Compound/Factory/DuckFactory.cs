using Compound.Animal;
using Compound.Interface;
using UnityEngine;

namespace Compound.Factory
{

    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallarDuck()
        {
            return new MallarDuck();
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }
    }
}