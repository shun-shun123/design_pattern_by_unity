using UnityEngine;

namespace State.Abstract
{

    public abstract class AbstractState
    {
        protected GumBallMachine GumBallMachine;
        
        public virtual void InsertQuarter()
        {
            Debug.Log("25セントを投入できません。");
        }

        public virtual void EjectQuarter()
        {
            Debug.Log("25セントを投入できません。");
        }

        public virtual void TurnCrank()
        {
            Debug.Log("クランクを回せません。");
        }

        public virtual void Dispense()
        {
            Debug.Log("ガムを排出できません。");
        }
    }
}