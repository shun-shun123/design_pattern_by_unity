using UnityEngine;

namespace Facade.SubSystems
{
    public class YouTube 
    {
        public void SearchVideoList()
        {
            Debug.Log("いくつかのビデオを表示します");
        }
        
        public void SelectVideo()
        {
            Debug.Log("一つのビデオを選択しました");
        }
    }
}