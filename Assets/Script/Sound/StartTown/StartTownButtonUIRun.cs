using UnityEngine;
using System;

public class StartTownButtonUIRun : MonoBehaviour
{
    public event System.Action<StartTownSEType> OnUISE;

     public void Open()
    {
        OnUISE?.Invoke(StartTownSEType.SettingButton);
    }

    public void Close()
    {
        OnUISE?.Invoke(StartTownSEType.backButton);
    }
}
