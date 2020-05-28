using Adapter.Interfaces;
using UnityEngine;

namespace Adapter.Animals
{

    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Debug.Log("ゴロゴロ鳴いています");
        }

        public void Fly()
        {
            Debug.Log("ちょこっと飛んでいます");
        }
    }
}