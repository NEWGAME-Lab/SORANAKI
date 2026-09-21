using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TitleUISePlayer : MonoBehaviour, ISeSetable
{

    [SerializeField] private AudioClip audioClipOpen;
    [SerializeField] private AudioClip audioClipClose;
    [SerializeField] private TitleButtonUIRun titleButtonUI;
    private float seVolume = 1.0f;

    private void Start()
    {
        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Register(this);
        }

        if (titleButtonUI != null)
        {
            titleButtonUI.OnButtonClick += OnButtonClick;
        }
    }

    public void SetSe(float volume)
    {
        Debug.Log("UIのSE音量: " + volume);

        seVolume = volume;
    }

    private void OnDestroy()
    {
        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Unregister(this);
        }
    }



    public void PlaySe(TitleSEType seType)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        switch (seType)
        {
            case TitleSEType.Open:
                if (audioClipOpen != null)
                {
                    
                    audioSource.PlayOneShot(audioClipOpen, seVolume);
                }
                else
                {
                    Debug.LogWarning("AudioClip is not assigned.");
                }
                break;
            case TitleSEType.Close:
                if (audioClipClose != null)
                {
                    audioSource.PlayOneShot(audioClipClose, seVolume);
                }
                else
                {
                    Debug.LogWarning("AudioClip is not assigned.");
                }
                break;
        }
    }


    private void OnButtonClick(TitleSEType seType)
    {
        PlaySe(seType);
    }


}
