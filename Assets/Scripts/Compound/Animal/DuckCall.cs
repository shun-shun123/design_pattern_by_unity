using System;
using Compound.Interface;
using UnityEngine;

namespace Compound.Animal
{

    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Debug.Log("ガアガア");
        }
    }
}