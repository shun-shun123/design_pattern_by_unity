using System;
using Compound.Animal;
using Compound.Decorator;
using Compound.Interface;

namespace Compound.Factory
{

    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallarDuck()
        {
            return new QuackCounter(new MallarDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}