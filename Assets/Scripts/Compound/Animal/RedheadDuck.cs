using System;
using Compound.Interface;
using UnityEngine;

namespace Compound.Animal
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Debug.Log("ガーガー");
        }
    }
}