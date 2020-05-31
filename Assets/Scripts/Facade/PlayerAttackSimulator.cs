using Facade.SubSystems;
using UnityEngine;

namespace Facade
{
    public class PlayerAttackSimulator : MonoBehaviour
    {
        void Start()
        {
            var playerAttack = new PlayerAttack();
            var attackEffect = new AttackEffect();
            var attackMotion = new AttackMotion();
            var playerAttackManager = new PlayerAttackManager(playerAttack, attackEffect, attackMotion);
            // サブシステムの機能をカプセル化した「攻撃する」という一連の処理を行うメソッド
            playerAttackManager.Attack();
            
            // サブシステムの個々のメソッドもアクセスはできる
            playerAttack.Attack();
            attackEffect.ShowAttackEffect();
            attackMotion.PlayAttackMotion();
        }
    }
}