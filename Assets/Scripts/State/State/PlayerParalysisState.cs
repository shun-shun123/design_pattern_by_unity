using State.Abstract;
using UnityEngine;

namespace State
{
    public class PlayerParalysisState : AbstractPlayerState
    {
        public PlayerParalysisState(PlayerAttack playerAttack)
        {
            base.PlayerAttack = playerAttack;
        }

        public override void Attack()
        {
            Debug.Log("痺れて攻撃できない");
            base.PlayerAttack.SetState(base.PlayerAttack.NormalState);
        }
    }
}