using UnityEngine;

///<summary>
/// SettingDataから設定値を取得し、ゲーム内の設定に反映する
/// </summary>
public class SettingDataReflect : MonoBehaviour
{
    //SEの音量を変更するAudioSourceへの参照
    [SerializeField]
    private AudioSource seAudioSource;

    public void ReflectData(SettingData settingData)
    {
        if (AudioSettings.Instance == null)
        {
            Debug.LogError("[SettingDataReflect] エラー: seAudioSource がアサインされていません！");
            return;
        }

        AudioSettings.Instance.SetSEVolume(settingData.volumes.SeVolume);
        AudioSettings.Instance.SetBGMVolume(settingData.volumes.BgmVolume);
        AudioSettings.Instance.SetMasterVolume(settingData.volumes.MasterVolume);

        Debug.Log($"[SettingDataReflect] 3. AudioSourceに反映完了！");
    }
}
