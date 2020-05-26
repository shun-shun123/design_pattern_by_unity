using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Strategy.Behaviour
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Debug.Log("飛べません。");
        }
    }
}