using Decorator.Interface;
using UnityEngine;

namespace Decorator.Player
{
    public class PlayerAction : IPlayerAction
    {
        public void Attack()
        {
            Debug.Log("攻撃します！");
        }
    }
}