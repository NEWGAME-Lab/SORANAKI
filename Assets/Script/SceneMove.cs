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

    private string nextScene;//シーン移動のステイトを管理するため後で状況に合わせて直す
  
    public void Move(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
