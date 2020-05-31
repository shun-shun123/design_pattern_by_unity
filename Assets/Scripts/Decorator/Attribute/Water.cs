using Decorator.Interface;
using UnityEngine;

namespace Decorator.Attribute
{

    public class Water : PlayerActionAttr
    {
        public Water(IPlayerAction playerAction)
        {
            base.PlayerAction = playerAction;
        }
        
        public override void Attack()
        {
            PlayerAction.Attack();
            Debug.Log("水属性の攻撃！");
        }
    }
}