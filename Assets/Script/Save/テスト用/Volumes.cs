using System;
using UnityEngine;

[Serializable]
public struct Volumes
{
    [SerializeField] private float masterVolume;
    [SerializeField] private float seVolume;
    [SerializeField] private float bgmVolume;

    public Volumes(float master, float se, float bgm)
    {
        masterVolume = master;
        seVolume = se;
        bgmVolume = bgm;
    }

    //これが俺のprivate回避だオラァ！
    public float MasterVolume => masterVolume;
    public float SeVolume     => seVolume;
    public float BgmVolume    => bgmVolume;
}