using Strategy.Behaviour;
using Strategy.Client;
using UnityEngine;

namespace Strategy
{
    public class GameManager : MonoBehaviour
    {
        private MallarDuck _mallarDuck = new MallarDuck();
        
        void Start()
        {
            _mallarDuck.Display();
            _mallarDuck.PerformFly();
            _mallarDuck.PerformQuack();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                _mallarDuck.SetFlyBehaviour(new FlyWithWings());
                _mallarDuck.SetQuackBehaviour(new Squack());
            } else if (Input.GetKeyDown(KeyCode.Space))
            {
                _mallarDuck.PerformFly();
                _mallarDuck.PerformQuack();
            }
        }
    }
}