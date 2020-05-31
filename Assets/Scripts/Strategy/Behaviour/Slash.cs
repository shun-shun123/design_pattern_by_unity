using Strategy.Interface;
using UnityEngine;

namespace Strategy.Behaviour
{
    public class Slash : IAttack
    {
        public void Attack()
        {
            Debug.Log("斬撃攻撃！");
        }
    }
}