using Strategy.Behaviour;
using UnityEngine;

namespace Strategy.Client
{
    public class MallarDuck : Duck
    {
        public MallarDuck()
        {
            _flyBehaviour = new FlyNoWay();
            _quackBehaviour = new MuteQuack();
        }
        
        public override void Display()
        {
            Debug.Log("初期状態では、飛べない、鳴けないカモです。");
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }
    }
}