using UnityEngine;

namespace State
{
    public class PlayerAttackManager : MonoBehaviour
    {
        private PlayerAttack _playerAttack = new PlayerAttack();
        void Start()
        {
            for (var i = 0; i < 10; i++)
            {
                _playerAttack.Attack();
            }
        }
    }
}