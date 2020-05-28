using System.Collections;
using System.Collections.Generic;
using State.Abstract;
using UnityEngine;

namespace State.State
{
    public class NoQuarterState : AbstractState
    {
        public NoQuarterState(GumBallMachine gumBallMachine)
        {
            base.GumBallMachine = gumBallMachine;
        }
        
        public override void InsertQuarter()
        {
            Debug.Log("25セントを投入しました");
            base.GumBallMachine.SetState(base.GumBallMachine.HasQuarterState);
        }
    }
}