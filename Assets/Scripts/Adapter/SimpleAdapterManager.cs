using System;
using Adapter.Animals;
using Adapter.Interfaces;
using UnityEngine;

namespace Adapter
{
    public class SimpleAdapterManager : MonoBehaviour
    {
        private void Start()
        {
            MallarDuck duck = new MallarDuck();
            
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);
            
            turkey.Gobble();
            turkey.Fly();
            
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
            
            duck.Quack();
            duck.Fly();
        }
    }
}