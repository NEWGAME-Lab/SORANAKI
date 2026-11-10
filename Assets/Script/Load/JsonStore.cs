using UnityEngine;

public class JsonStore
{
    public SettingData Store(string json)
    {
        //JSON文字列を構造体に変換する
        SettingData settingData = JsonUtility.FromJson<SettingData>(json);

        Debug.Log($"[JsonStore] 2. 構造体への変換完了 -> Master: {settingData.volumes.MasterVolume}, SE: {settingData.volumes.SeVolume}, BGM: {settingData.volumes.BgmVolume}");

        return settingData;
    }
}
