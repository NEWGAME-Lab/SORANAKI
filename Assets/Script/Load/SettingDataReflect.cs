using UnityEngine;

[System.Serializable]
public struct SettingData
{
    public Volumes volumes;
}

[System.Serializable]
public struct Volumes
{
    public float masterVolume;
    public float seVolume;
    public float bgmVolume;
}

public class SettingDataReflect : MonoBehaviour
{
    [SerializeField]
    private AudioSource seAudioSource;

    public void ReflectData(SettingData settingData)
    {
        //SE音量をゲーム側に反映する
        seAudioSource.volume = settingData.volumes.seVolume;
    }
}
