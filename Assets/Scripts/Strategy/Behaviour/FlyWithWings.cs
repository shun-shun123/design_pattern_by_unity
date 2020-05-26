using UnityEngine;

namespace Strategy.Behaviour
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Debug.Log("羽ばたきました！");
        }
    }
}