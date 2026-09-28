using UnityEngine;

///<summary>
/// 各シーンのFPSを管理するクラス
/// </summary>
public class FPSController : MonoBehaviour
{
    private void Awake()
    {
        //FPs変更イベントを登録
        if (FPSSetting.Instance != null)
        {
            FPSSetting.Instance.FPSChange += OnFPSChange;
            //Debug.Log("[FPSController] Awake : FPSChangeイベントを登録しました。");
        }
        else
        {
            //Debug.LogError("[FPSController] FPSSettingのInstanceが見つかりません。");
        }
    }

    private void Start()
    {
        //現在のFPSを取得
        if (FPSSetting.Instance != null)
        {
            float fps = FPSSetting.Instance.GetFPS();
            //Debug.Log("[FPSController] Start：現在のFPSを取得しました → " + fps);

            SetFPS(fps);
        }
    }

    ///<summary>
    /// FPS変更イベントを受け取る
    /// </summary>
    private void OnFPSChange(float fps)
    {
        //Debug.Log("[FPSController] OnFPSChange：FPS変更を受け取りました → " + fps);
        SetFPS(fps);
    }

    ///<summary>
    /// FPSをこのシーンに適用する
    /// </summary>
    private void SetFPS(float fps)
    {
        Application.targetFrameRate = Mathf.RoundToInt(fps);
        //Debug.Log("[FPSController] SetFPS：このシーンのFPSを " + fps + " に設定しました。");
    }

    private void OnDisable()
    {
        //FPS変更イベントの登録解除
        if (FPSSetting.Instance != null)
        {
            FPSSetting.Instance.FPSChange -= OnFPSChange;
            //Debug.Log("[FPSController] OnDisable：FPSChangeイベントを解除しました。");
        }
    }
}
