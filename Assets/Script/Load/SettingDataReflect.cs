using UnityEngine;


public class SettingDataReflect : MonoBehaviour
{
    [SerializeField]
    private AudioSource seAudioSource;

    public void ReflectData(SettingData settingData)
    {
        if (seAudioSource == null)
        {
            Debug.LogError("[SettingDataReflect] エラー: seAudioSource がアサインされていません！");
            return;
        }
        //SE音量をゲーム側に反映する
        seAudioSource.volume = settingData.volumes.SeVolume;

        Debug.Log($"[SettingDataReflect] 3. AudioSourceに反映完了！ 変更後の音量: {seAudioSource.volume}");
    }
}
