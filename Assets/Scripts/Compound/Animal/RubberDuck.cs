using Compound.Interface;
using UnityEngine;

namespace Compound.Animal
{
    public class RubberDuck : IQuackable
    {
        public void Quack()
        {
            Debug.Log("キューキュー");
        }
    }
}