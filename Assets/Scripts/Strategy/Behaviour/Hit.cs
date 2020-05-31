using Strategy.Interface;
using UnityEngine;

namespace Strategy.Behaviour
{
    public class Hit : IAttack
    {
        public void Attack()
        {
            Debug.Log("打撃攻撃！");
        }
    }
}