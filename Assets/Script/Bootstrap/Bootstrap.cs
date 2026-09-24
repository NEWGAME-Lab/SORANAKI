using UnityEngine;

public static class Bootstrap 
{
    [RuntimeInitializeOnLoadMethod(
         RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        GameObject prefab =
                Resources.Load<GameObject>("PersistentSystems");

        GameObject instance = Object.Instantiate(prefab);

        Object.DontDestroyOnLoad(instance);
    }
}
