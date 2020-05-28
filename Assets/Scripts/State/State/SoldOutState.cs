using State.Abstract;
using UnityEngine;

namespace State.State
{
    public class SoldOutState : AbstractState
    {
        public SoldOutState(GumBallMachine machine)
        {
            base.GumBallMachine = machine;
        }
    }
}