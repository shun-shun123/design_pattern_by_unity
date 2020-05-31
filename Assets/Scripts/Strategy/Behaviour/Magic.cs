using Strategy.Interface;
using UnityEngine;

namespace Strategy.Behaviour
{
    public class Magic : IAttack
    {
        public void Attack()
        {
            Debug.Log("魔法攻撃！");
        }
    }
}