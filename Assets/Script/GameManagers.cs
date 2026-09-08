using UnityEngine;
using Unity.Scripting.LifecycleManagement;

[AutoStaticsCleanup]
public partial class GameManagers : MonoBehaviour
{
    public static GameManagers Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
