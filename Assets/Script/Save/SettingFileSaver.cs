using System.IO;
using UnityEngine;

public class SettingFileSaver
{
    private const string FileName = "setting.json";

    private readonly SettingDataCollector collector = new SettingDataCollector();
    private readonly JsonCreator jsonCreator = new JsonCreator();

    public void JsonSave()
    {
        SettingData data = collector.Collect();
        string json = jsonCreator.JsonCreate(data);

        string path = Path.Combine(Application.persistentDataPath, FileName);
        File.WriteAllText(path, json);
    }
}