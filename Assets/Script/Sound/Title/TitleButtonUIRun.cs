using UnityEngine;

public class TitleButtonUIRun : MonoBehaviour
{
    public event System.Action<TitleSEType> OnButtonClick;

    public void OpenButtonClick()
    {
        OnButtonClick?.Invoke(TitleSEType.Open);
    }

    public void CloseButtonClick()
    {
        OnButtonClick?.Invoke(TitleSEType.Close);
    }
}
