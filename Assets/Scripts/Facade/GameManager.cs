using Facade.SubSystems;
using UnityEngine;


namespace Facade
{

    public class GameManager : MonoBehaviour
    {
        private Study _study;
        void Start()
        {
            _study = new Study(new HeadPhone(), new YouTube(), new Computer());
            _study.StartProgramming();
        }
    }
}