using UnityEngine;

///<summary>
/// Json文字列をSettingDataの構造体に変換するクラス
/// </summary>
public class JsonStore
{
    public SettingData Store(string json)
    {
        //JSON文字列を構造体に変換する
        SettingData settingData = JsonUtility.FromJson<SettingData>(json);

        // 変換した設定値をコンソールに出力し、正しく取得できているか確認する
        Debug.Log($"[JsonStore] 2. 構造体への変換完了 -> Master: {settingData.volumes.MasterVolume}, SE: {settingData.volumes.SeVolume}, BGM: {settingData.volumes.BgmVolume}");

         // 変換したSettingDataを呼び出し元のJsonLoaderに返す
        return settingData;
    }
}
