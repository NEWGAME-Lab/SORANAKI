using UnityEngine;

/// <summary>
/// 実際のフレームレートを確認するためのクラス
/// </summary>
public class FPSMonitor : MonoBehaviour
{
    private float elapsedTime;
    private int frameCount;

    private void Update()
    {
        frameCount++;
        elapsedTime += Time.unscaledDeltaTime;

        // 1秒ごとにFPSを計算
        if (elapsedTime >= 1f)
        {
            float fps = frameCount / elapsedTime;

            //Debug.Log("[FPSMonitor] 実測FPS：" + fps);

            frameCount = 0;
            elapsedTime = 0f;
        }
    }
}