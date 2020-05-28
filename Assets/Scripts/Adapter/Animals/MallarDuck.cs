using Adapter.Interfaces;
using UnityEngine;

namespace Adapter.Animals
{
    public class MallarDuck : IDuck
    {
        public void Quack()
        {
            Debug.Log("ガーガー鳴いています");
        }

        public void Fly()
        {
            Debug.Log("飛んでいます");
        }
    }
}