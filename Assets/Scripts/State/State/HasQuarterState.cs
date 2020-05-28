using State.Abstract;
using UnityEngine;

namespace State.State
{
    public class HasQuarterState : AbstractState
    {
        public HasQuarterState(GumBallMachine machine)
        {
            base.GumBallMachine = machine;
        }

        public override void InsertQuarter()
        {
            Debug.Log("すでに25セント入れています。");
        }

        public override void EjectQuarter()
        {
            Debug.Log("25セントを返却しました。");
            base.GumBallMachine.SetState(base.GumBallMachine.NoQuarterState);
        }

        public override void TurnCrank()
        {
            Debug.Log("トランクを回しました。");
            if (Random.Range(0, 10) == 0 && base.GumBallMachine.GumCount > 1)
            {
                base.GumBallMachine.SetState(base.GumBallMachine.WinnerState);
            }
            else
            {
                base.GumBallMachine.SetState(base.GumBallMachine.SoldState);
            }
        }
    }
}