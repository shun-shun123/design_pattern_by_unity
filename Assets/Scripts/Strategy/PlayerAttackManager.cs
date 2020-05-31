using Strategy.Behaviour;
using Strategy.Client;
using UnityEngine;

namespace Strategy
{

    public class PlayerAttackManager : MonoBehaviour
    {
        void Start()
        {
            var hit = new Hit();
            var slash = new Slash();
            var magic = new Magic();
            
            // 初期状態は打撃攻撃に設定する
            var playerAttack = new PlayerAttack(hit);
            playerAttack.Attack();
            
            // 斬撃攻撃に切り替える
            playerAttack.SetAttack(slash);
            playerAttack.Attack();
            
            // 魔法攻撃に切り替える
            playerAttack.SetAttack(magic);
            playerAttack.Attack();
        }
    }
}