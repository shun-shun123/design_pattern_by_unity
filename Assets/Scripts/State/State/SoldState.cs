using State.Abstract;
using UnityEngine;

namespace State.State
{

    public class SoldState : AbstractState
    {
        public SoldState(GumBallMachine machine)
        {
            base.GumBallMachine = machine;
        }
        
        public override void Dispense()
        {
            base.GumBallMachine.ReleaseBall();
            if (base.GumBallMachine.GumCount > 0)
            {
                base.GumBallMachine.SetState(base.GumBallMachine.NoQuarterState);
            }
            else
            {
                Debug.Log("ガムが残りありません。");
                base.GumBallMachine.SetState(base.GumBallMachine.SoldOutState);
            }
        }
    }
}