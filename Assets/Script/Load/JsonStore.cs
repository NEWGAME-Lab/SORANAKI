using UnityEngine;

public class JsonStore
{
    public SettingData Store(string json)
    {
        //JSON文字列を構造体に変換する
        SettingData settingData = JsonUtility.FromJson<SettingData>(json);

        return settingData;
    }
}
