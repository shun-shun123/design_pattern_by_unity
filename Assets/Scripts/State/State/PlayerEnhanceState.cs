using State.Abstract;
using UnityEngine;

namespace State
{
    public class PlayerEnhanceState : AbstractPlayerState
    {
        public PlayerEnhanceState(PlayerAttack playerAttack)
        {
            base.PlayerAttack = playerAttack;
        }

        public override void Attack()
        {
            Debug.Log("二倍の攻撃！！");
            base.PlayerAttack.SetState(Random.Range(0, 2) == 0 ? base.PlayerAttack.ParalysisState : base.PlayerAttack.NormalState);
        }
    }
}