using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Facade.SubSystems
{

    public class HeadPhone
    {
        public void PowerOn()
        {
            Debug.Log("ヘッドホンの電源を入れます");
        }

        public void Connect()
        {
            Debug.Log("ヘッドホンを接続します");
        }
    }
}