using Compound.Interface;
using UnityEngine;

namespace Compound.Decorator
{

    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private static int _numberOfQuack;

        public QuackCounter(IQuackable quackable)
        {
            _duck = quackable;
        }


        public void Quack()
        {
            _duck.Quack();
            _numberOfQuack++;
        }

        public static int GetQuacks()
        {
            return _numberOfQuack;
        }
    }
}