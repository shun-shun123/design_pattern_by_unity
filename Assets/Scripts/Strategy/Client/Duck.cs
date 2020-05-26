using System.Collections;
using System.Collections.Generic;
using Strategy.Behaviour;
using UnityEngine;

namespace Strategy.Client
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }

        public void Swim()
        {
            Debug.Log("泳ぎます。");
        }
    }
}