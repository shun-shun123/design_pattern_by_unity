using UnityEngine;

namespace Singleton
{
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    var t = typeof(T);

                    instance = FindObjectOfType<T>();
                    if (instance == null)
                    {
                        Debug.LogError(t + " をアタッチしているGameObjectはありません");
                    }
                }
                return instance;
            }
        }
    }
}