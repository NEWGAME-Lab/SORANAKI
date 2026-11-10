using UnityEngine;

public class JsonCreator
{
    public string JsonCreate(SettingData data)
    {
        return JsonUtility.ToJson(data, true);
    }
}