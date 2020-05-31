using Strategy.Interface;

namespace Strategy.Client
{

    public class PlayerAttack
    {
        private IAttack _attack;

        public PlayerAttack(IAttack attack)
        {
            _attack = attack;
        }

        public void Attack()
        {
            _attack.Attack();
        }

        public void SetAttack(IAttack attack)
        {
            _attack = attack;
        }
    }
}