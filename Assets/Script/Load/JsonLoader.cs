using UnityEngine;
using System.IO;

public class JsonLoader : MonoBehaviour
{
    //設定値をゲーム内に反映するクラスの参照
    //InspectorからSettingDataReflectをアサインする
    [SerializeField]
    private SettingDataReflect settingDataReflect;

    ///<summary>
    /// Jsonデータを読み込み、構造体に変換してゲーム内に反映する処理
    /// </summary>
    
    public void JsonLoad()
    {
        //実際のJsonファイルを読み込む場合
        //保存先のパスを取得する
        string path = Application.persistentDataPath + "/setting.json"; //persistentDataPathはゲームのセーブデータなどを保存する場所

        //指定した場所にJsonファイルがあるか確認する
        if (!File.Exists(path)){
            Debug.LogError("JSONファイルが見つかりませんでした");
            return;
        }

        //Jsonファイルの内容を文字列として読み込む
        string json = File.ReadAllText(path);
        Debug.Log("JSONファイルの読み込みが完了しました。");
        

        //JsonStoreで構造体に変換する
        JsonStore jsonStore = new JsonStore();
        SettingData settingData = jsonStore.Store(json);

        //SettingDataReflectでゲーム側に反映する
        if(settingDataReflect != null)
        {
            settingDataReflect.ReflectData(settingData);
        }
        else
        {
            Debug.LogError("[JsonLoader] エラー: settingDataReflect がアサインされていません！");
        }

    }

    //Jsonの読み込み処理を実行する
    private void Awake()
    {
        JsonLoad();
    }
}
