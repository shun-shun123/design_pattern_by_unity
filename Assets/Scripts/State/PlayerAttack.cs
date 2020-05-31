using System.Collections;
using System.Collections.Generic;
using State.Abstract;
using UnityEngine;

namespace State
{
    public class PlayerAttack
    {
        public AbstractPlayerState NormalState { get; private set; }
        public AbstractPlayerState EnhanceState { get; private set; }
        public AbstractPlayerState ParalysisState { get; private set; }
        private AbstractPlayerState _currentState;

        public PlayerAttack()
        {
            NormalState = new PlayerNormalState(this);
            EnhanceState = new PlayerEnhanceState(this);
            ParalysisState = new PlayerParalysisState(this);
            _currentState = NormalState;
        }
        
        public void Attack()
        {
            _currentState.Attack();
        }

        public void SetState(AbstractPlayerState state)
        {
            _currentState = state;
        }
    }
}