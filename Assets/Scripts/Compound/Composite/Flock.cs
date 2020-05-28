using System.Collections;
using System.Collections.Generic;
using Compound.Interface;
using UnityEngine;

namespace Compound.Composite
{

    public class Flock : IQuackable
    {
        private List<IQuackable> _quackables = new List<IQuackable>();

        public void Add(IQuackable quackable)
        {
            _quackables.Add(quackable);
        }
        
        public void Quack()
        {
            foreach (var quack in _quackables)
            {
                quack.Quack();
            }
        }
    }
}