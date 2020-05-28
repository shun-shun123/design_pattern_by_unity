using System.Collections;
using System.Collections.Generic;
using Compound.Adapter;
using Compound.Animal;
using Compound.Composite;
using Compound.Decorator;
using Compound.Factory;
using Compound.Interface;
using UnityEngine;

namespace Compound
{

    public class GameManager : MonoBehaviour
    {
        private AbstractDuckFactory _duckFactory = new CountingDuckFactory();
        
        void Start()
        {
            var flock = new Flock();
            IQuackable mallarDuck = _duckFactory.CreateMallarDuck();
            IQuackable redheadDuck = _duckFactory.CreateRedheadDuck();
            IQuackable duckCall = _duckFactory.CreateDuckCall();
            IQuackable rubberDuck = _duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            flock.Add(mallarDuck);
            flock.Add(redheadDuck);
            flock.Add(duckCall);
            flock.Add(rubberDuck);

            flock.Quack();
            gooseDuck.Quack();
            Debug.Log($"QuackCount: {QuackCounter.GetQuacks()}");
        }
    }
}