using UnityEngine;

namespace State.Abstract
{
    public class AbstractPlayerState
    {
        protected PlayerAttack PlayerAttack;
        
        public virtual void Attack()
        {
            Debug.Log("攻撃方法が定義されていません");
        }
    }
}