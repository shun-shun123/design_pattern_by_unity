using Facade.SubSystems;

namespace Facade
{
    public class PlayerAttackManager
    {
        private PlayerAttack _playerAttack;
        private AttackEffect _attackEffect;
        private AttackMotion _attackMotion;

        public PlayerAttackManager(PlayerAttack playerAttack, AttackEffect attackEffect, AttackMotion attackMotion)
        {
            _playerAttack = playerAttack;
            _attackEffect = attackEffect;
            _attackMotion = attackMotion;
        }

        /// <summary>
        /// 攻撃判定・エフェクト再生・モーション再生
        /// をカプセル化した「攻撃する」という処理を行うメソッド
        /// </summary>
        public void Attack()
        {
            _playerAttack.Attack();
            _attackEffect.ShowAttackEffect();
            _attackMotion.PlayAttackMotion();
        }
    }
}