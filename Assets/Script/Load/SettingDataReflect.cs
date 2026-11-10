using UnityEngine;


public class SettingDataReflect : MonoBehaviour
{
    [SerializeField]
    private AudioSource seAudioSource;

    public void ReflectData(SettingData settingData)
    {
        //SE音量をゲーム側に反映する
        seAudioSource.volume = settingData.Volumes.se;
    }
}
