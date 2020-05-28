using System;
using UnityEngine;

namespace State
{

    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            var machine = new GumBallMachine(30);
            for (var i = 0; i < 10; i++)
            {
                machine.InsertQuarter();
                machine.EjectQuarter();
                machine.InsertQuarter();
                machine.TurnCrank();
            }
            Debug.Log($"残りガム数: {machine.GumCount}");
        }
    }
}