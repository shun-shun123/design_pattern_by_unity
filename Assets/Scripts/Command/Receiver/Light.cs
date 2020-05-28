using UnityEngine;

namespace Command.Receiver
{
    public class Light
    {
        public void On()
        {
            Debug.Log("Light On");
        }

        public void Off()
        {
            Debug.Log("Light Off");
        }
    }
}