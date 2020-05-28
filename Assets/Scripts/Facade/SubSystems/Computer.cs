using UnityEngine;

namespace Facade.SubSystems
{

    public class Computer
    {
        public void PowerOn()
        {
            Debug.Log("PCの電源を入れます");
        }

        public void OpenIDE()
        {
            Debug.Log("IDEを立ち上げます");
        }
    }
}