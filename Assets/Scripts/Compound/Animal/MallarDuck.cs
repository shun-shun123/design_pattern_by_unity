using System.Collections;
using System.Collections.Generic;
using Compound.Interface;
using UnityEngine;

namespace Compound.Animal
{
    public class MallarDuck : IQuackable
    {
        public void Quack()
        {
            Debug.Log("ガーガー");
        }
    }
}