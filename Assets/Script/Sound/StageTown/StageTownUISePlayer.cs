using UnityEngine;

public enum SEType
{
    SE1,
    SE2
}

[RequireComponent(typeof(AudioSource))]
public class StageTownUISePlayer : MonoBehaviour, ISeSetable
{
    //[SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip se1Clip;
    [SerializeField] private AudioClip se2Clip;
    private AudioSource audioSource;
    private void Start()
    { 
        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Register(this);
        }
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        StageTownButtonRun.OnSEPlayRequested += PlaySe;
    }

    private void OnDisable()
    {
        StageTownButtonRun.OnSEPlayRequested -= PlaySe;
    }

    private void OnDestroy()
    {
        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Unregister(this);
        }
    }

    //イベント受け取り
    private void PlaySe(SEType type)
    {
        AudioClip targetClip = type switch
        {
            SEType.SE1 => se1Clip,
            SEType.SE2 => se2Clip,
            _ => null
        };

        if (targetClip != null && audioSource != null)
        {
            audioSource.PlayOneShot(targetClip);
        }
    }

    //音量設定
    public void SetSe(float volume)
    {
        if (audioSource != null)
        {
            audioSource.volume = volume;
        }
        Debug.Log("SE volume: " + volume);
    }
}