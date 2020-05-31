using Decorator.Attribute;
using Decorator.Interface;
using Decorator.Player;
using UnityEngine;

namespace Decorator
{
    public class PlayerActionManager : MonoBehaviour
    {
        private void Start()
        {
            IPlayerAction playerAction = new PlayerAction();
            playerAction.Attack();
            
            // PlayerActionをPoisonで装飾して毒属性を追加
            playerAction = new Poison(playerAction);
            playerAction.Attack();

            // さらに水属性を追加する
            playerAction = new Water(playerAction);
            playerAction.Attack();
        }
    }
}