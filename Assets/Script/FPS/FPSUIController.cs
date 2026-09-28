using UnityEngine;

///<summary>
/// FPS設定用のUIを管理するクラス
/// </summary>
public class FPSUIController : MonoBehaviour
{
    ///<summary>
    /// FPSの設定
    /// </summary>
    public void SetFPS(float fps)
    {
        if (FPSSetting.Instance == null)
        {
            //Debug.LogError("[FPSUIController] FPSSettingのInstanceが見つかりません。");
            return;
        }

        FPSSetting.Instance.SetFPS(fps);

        //Debug.Log("[FPSUIController] FPSSettingに " + fps + " を設定しました。");
    }
}
