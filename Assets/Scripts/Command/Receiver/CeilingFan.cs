using UnityEngine;

namespace Command.Receiver
{
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MIDDLE = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        public int Speed { get; private set; }

        public CeilingFan()
        {
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
            Debug.Log("Speed: HIGH");
        }

        public void Middle()
        {
            Speed = MIDDLE;
            Debug.Log("Speed: MIDDLE");
        }

        public void Low()
        {
            Speed = LOW;
            Debug.Log("Speed: LOW");
        }

        public void Off()
        {
            Speed = OFF;
            Debug.Log("Speed: OFF");
        }
    }
}