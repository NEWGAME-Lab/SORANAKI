using Unity.Scripting.LifecycleManagement;
using UnityEngine;

[AutoStaticsCleanup]
public partial class AudioSettings : MonoBehaviour
{
    public static AudioSettings Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // 初期化処理が必要な場合はここに記述
        Debug.Log("SE Volume changed : " + seVolume);
    }


    private float masterVolume = 0.5f;
    private float bgmVolume = 0.5f;
    private float seVolume = 0.5f;

    public event System.Action<float> OnMasterVolumeChanged;
    public event System.Action<float> OnBGMVolumeChanged;
    public event System.Action<float> OnSEVolumeChanged;    

    /*----設定関数-----*/
    public void SetMasterVolume(float volume)
    {
        masterVolume = volume;
        OnMasterVolumeChanged?.Invoke(masterVolume);
    }

    public void SetBGMVolume(float volume)
    {
        bgmVolume = volume;
        OnBGMVolumeChanged?.Invoke(bgmVolume);
    }

    public void SetSEVolume(float volume)
    {
        seVolume = volume;
        OnSEVolumeChanged?.Invoke(seVolume);
        Debug.Log("音量コントローラー(SE) : " + seVolume);
    }
    /*----取得関数-----*/
    public float GetMasterVolume()
    {
        return masterVolume;
    }

    public float GetBGMVolume()
    {
        return bgmVolume;
    }

    public float GetSEVolume()
    {
        return seVolume;
    }

}
