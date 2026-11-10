using UnityEngine;
using System.IO;

public class JsonLoader : MonoBehaviour
{
    [SerializeField]
    private SettingDataReflect settingDataReflect;


    public void JsonLoad()
    {
        //仮の音量を読みこむ
        string json = "{\"volumes\":{\"masterVolume\":1.0,\"seVolume\":0.8,\"bgmVolume\":0.5}}";

        //実際のJsonファイルを読み込む場合
        /*
        string path = Application.persistentDataPath + "/setting.json";

        if (!File.Exists(path)){
            Debug.Log("JSONファイルが見つかりませんでした");
            return;
        }

        string json = File.ReadAllText(path);
        */

        //JsonStoreで構造体に変換する
        JsonStore jsonStore = new JsonStore();
        SettingData settingData = jsonStore.Store(json);

        //SettingDataReflectでゲーム側に反映する
        settingDataReflect.ReflectData(settingData);

    }

    private void Start()
    {
        JsonLoad();
    }
}
