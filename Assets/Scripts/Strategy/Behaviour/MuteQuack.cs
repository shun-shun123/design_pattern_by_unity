using UnityEngine;

namespace Strategy.Behaviour
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.Log("...");
        }
    }
}