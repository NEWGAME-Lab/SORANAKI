using UnityEngine;
using System;

public class StageButtonUIRun : MonoBehaviour
{
    public event System.Action<StageSEType> OnUISE;

     public void Open()
    {
        OnUISE?.Invoke(StageSEType.SettingButton);
    }

    public void Close()
    {
        OnUISE?.Invoke(StageSEType.backButton);
    }
}
