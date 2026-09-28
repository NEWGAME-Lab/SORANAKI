using UnityEngine;
using System;
using Unity.Scripting.LifecycleManagement;


///<summary>
/// ゲーム全体のFPS設定を管理するクラス
/// </summary>
[AutoStaticsCleanup]
public partial class FPSSetting : MonoBehaviour
{
    ///<summary>
    /// FPSSettingのインスタンス
    /// </summary>
    public static FPSSetting Instance {get; private set; }

    ///<summary>
    /// 現在設定されてるFPS
    /// </summary>
    [SerializeField] private float FPS = 60f;

    ///<summary>
    /// FPS変更時の発火イベント
    /// </summary>
    public event Action<float> FPSChange;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        //Debug.Log("[FPSSetting] Awake：FPSSettingを初期化しました。");
        //Debug.Log("[FPSSetting] 現在のFPS：" + FPS);
    }

    ///<summary>
    /// FPSを取得
    /// </summary>
    public float GetFPS()
    {
        //Debug.Log("[FPSSetting] GetFPS()：現在のFPSを取得しました → " + FPS);
        return FPS;
    }

    ///<summary>
    /// FPSの設定
    /// </summary>
    public void SetFPS(float fps)
    {
        FPS = fps;
        //Debug.Log("[FPSSetting] SetFPS()：FPSを " + FPS + " に設定しました。");

        FPSChange?.Invoke(FPS);
        //Debug.Log("[FPSSetting] FPSChangeイベントを発火しました。");
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
            //Debug.Log("[FPSSetting] OnDestroy：FPSSettingを破棄しました。");
        }
    }
}
