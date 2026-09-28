using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// FPS設定ボタンのUI状態を管理するクラス
/// </summary>
public class FPSUIState : MonoBehaviour
{
    [SerializeField] private Button fps30Button;
    [SerializeField] private Button fps60Button;

    [SerializeField] private Color selectedColor = Color.gray;
    [SerializeField] private Color normalColor = Color.white;

    /// <summary>
    /// 30FPSボタンを選択状態にする
    /// </summary>
    public void Select30FPS()
    {
        SetButtonColor(fps30Button, selectedColor);
        SetButtonColor(fps60Button, normalColor);

    }

    /// <summary>
    /// 60FPSボタンを選択状態にする
    /// </summary>
    public void Select60FPS()
    {
        SetButtonColor(fps30Button, normalColor);
        SetButtonColor(fps60Button, selectedColor);

    }

    /// <summary>
    /// ボタンの色を変更する
    /// </summary>
    /// <param name="button">色を変更するボタン</param>
    /// <param name="color">設定する色</param>
    private void SetButtonColor(Button button, Color color)
    {
        if (button == null)
        {
            return;
        }

        ColorBlock colors = button.colors;
        colors.normalColor = color;
        colors.selectedColor = color;
        colors.highlightedColor = color;

        button.colors = colors;
    }
}