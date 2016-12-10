using UnityEngine;

namespace MonoLightTech.UnityUtil
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                _instance = FindObjectOfType<T>();

                if (_instance != null)
                    return _instance;

                var gObj = new GameObject(string.Format("[{0}]", typeof(T).Name));
                _instance = gObj.AddComponent<T>();

                return _instance;
            }
        }

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
             //   DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
        }
    }
}