using System.Collections.Generic;
using Unity.Scripting.LifecycleManagement;
using UnityEngine;
using System.Collections;


[AutoStaticsCleanup]
public partial class SeVolumeController : MonoBehaviour
{
    public static SeVolumeController Instance { get; private set; }

    private readonly List<ISeSetable> seSetables = new List<ISeSetable>();

    bool isInitialized = true;
    AudioSettings audioSettings;
    private void Awake()
    {
        Instance = this;
    }

    private IEnumerator Start()
    {
        /*----AudioSettingsのインスタンスを取得-----*/
        audioSettings = AudioSettings.Instance;
        if (audioSettings == null)
        {
            Debug.LogError("AudioSettings instance is null.");
            yield break;
        }
        // SE音量の変更イベントにリスナーを登録
        audioSettings.OnSEVolumeChanged += OnSEVolumeChanged;
        

        /*-----SE音源の登録(それぞれのオブジェクトで行う)-----*/
        yield return new WaitForEndOfFrame(); // 1フレーム待機してから登録
        // 初期値を設定
        OnSEVolumeChanged(audioSettings.GetSEVolume());

        isInitialized = false;
    }

    /// <summary>
    /// SE音源を登録する
    /// </summary>
    public void Register(ISeSetable seObject)
    {
        if (seObject == null)
        {
            return;
        }

        // 重複登録防止
        if (seSetables.Contains(seObject))
        {
            return;
        }

        seSetables.Add(seObject);

        // 初期化完了後に生成されたSEには、その場で現在音量を設定
        if (!isInitialized && audioSettings != null)
        {
            seObject.SetSe(audioSettings.GetSEVolume());
        }
    }
    
    /// <summary>
    /// SE音源を登録解除する
    /// </summary>
    public void Unregister(ISeSetable seObject)
    {
        if (seObject == null)
        {
            return;
        }
        seSetables.Remove(seObject);
    }

    private void OnSEVolumeChanged(float volume)
    {
        seSetables.ForEach(se => se.SetSe(volume));
        Debug.Log("SE音量変更イベント発火: " + volume);
    }

    private void OnDestroy()
    {
        if (audioSettings != null)
        {
            audioSettings.OnSEVolumeChanged -= OnSEVolumeChanged;
        }

        if (Instance == this)
        {
            Instance = null;
        }
    }


}
