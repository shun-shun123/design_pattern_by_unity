using UnityEngine;

namespace Strategy.Behaviour
{
    public class Squack : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.Log("キュワッ！");
        }
    }
}