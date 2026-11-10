using System.IO;
using UnityEngine;

public class SettingSaveTester : MonoBehaviour
{
    [ContextMenu("Save Test")]
    private void SaveTest()
    {
        new SettingFileSaver().JsonSave();

        string path = Path.Combine(Application.persistentDataPath, "setting.json");
        Debug.Log("保存先: " + path);
        Debug.Log(File.ReadAllText(path));
    }
}