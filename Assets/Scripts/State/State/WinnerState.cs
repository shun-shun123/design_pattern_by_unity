using State.Abstract;
using UnityEngine;

namespace State.State
{
    public class WinnerState : AbstractState
    {
        public WinnerState(GumBallMachine machine)
        {
            base.GumBallMachine = machine;
        }
        
        public override void Dispense()
        {
            Debug.Log("あたりです！2つガムボールがもらえます。");
            base.GumBallMachine.ReleaseBall();
            if (base.GumBallMachine.GumCount == 0)
            {
                base.GumBallMachine.SetState(base.GumBallMachine.SoldOutState);
            }
            else
            {
                if (base.GumBallMachine.GumCount > 0)
                {
                    base.GumBallMachine.SetState(base.GumBallMachine.NoQuarterState);                    
                }
                else
                {
                    Debug.Log("ガムボールがなくなりました。");
                    base.GumBallMachine.SetState(base.GumBallMachine.SoldOutState);
                }
            }
        }
    }
}