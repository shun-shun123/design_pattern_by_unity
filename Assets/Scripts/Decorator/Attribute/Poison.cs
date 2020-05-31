using Decorator.Interface;
using UnityEngine;

namespace Decorator.Attribute
{
    public class Poison : PlayerActionAttr
    {
        public Poison(IPlayerAction playerAction)
        {
            base.PlayerAction = playerAction;
        }
        
        public override void Attack()
        {
            PlayerAction.Attack();
            Debug.Log("加えて毒属性のダメージ！");
        }
    }
}