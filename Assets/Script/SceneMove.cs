using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Scripting.LifecycleManagement;

/// <summary>
/// シーン遷移を実行するクラス。
/// シーン遷移条件を確認したクラスから呼び出される。
/// </summary>
[AutoStaticsCleanup]
public partial class SceneMove : MonoBehaviour
{
    public static SceneMove Instance { get; private set; }
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

    public void Move(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
