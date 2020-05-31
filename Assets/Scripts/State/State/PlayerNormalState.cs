using State.Abstract;
using UnityEngine;

namespace State
{
    public class PlayerNormalState : AbstractPlayerState
    {
        public PlayerNormalState(PlayerAttack playerAttack)
        {
            base.PlayerAttack = playerAttack;
        }

        public override void Attack()
        {
            Debug.Log("通常攻撃！");
            if (Random.Range(0, 5) >= 2)
            {
                base.PlayerAttack.SetState(base.PlayerAttack.EnhanceState);
            }
        }
    }
}