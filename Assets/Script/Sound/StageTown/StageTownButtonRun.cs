using System;
using UnityEngine;
using UnityEngine.UI;

public class StageTownButtonRun : MonoBehaviour
{
    public static event Action<SEType> OnSEPlayRequested;

    [SerializeField] private Button buttonSE1;
    [SerializeField] private Button buttonSE2;

    private void Start()
    {
        if (buttonSE1 != null)
        {
            buttonSE1.onClick.AddListener(() => RequestSe(SEType.SE1));
        }

        if (buttonSE2 != null)
        {
            buttonSE2.onClick.AddListener(() => RequestSe(SEType.SE2));
        }
    }

    // イベントの発火
    public void RequestSe(SEType type)
    {
        OnSEPlayRequested?.Invoke(type);
    }
}