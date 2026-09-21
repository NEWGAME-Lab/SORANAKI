using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StartTownUISePlayer : MonoBehaviour, ISeSetable
{
    [SerializeField] private AudioClip openSe;
    [SerializeField] private AudioClip closeSe;

    [SerializeField] private StartTownButtonUIRun buttonUIRun;

    private AudioSource audioSource;
    private float volume;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (buttonUIRun != null)
        {
            buttonUIRun.OnUISE += PlaySE;
        }

        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Register(this);
        }
    }


    private void PlaySE(StartTownSEType type)
    {
        switch (type)
        {
            case StartTownSEType.SettingButton:
                audioSource.PlayOneShot(openSe);
                break;
            
            case StartTownSEType.backButton:
                audioSource.PlayOneShot(closeSe);
                break;
        }
    }

    public void SetSe(float volume)
    {
        Debug.Log("UIのSE音量: " + volume);

    }

    private void OnDestroy()
    {
        if (buttonUIRun != null)
        {
            buttonUIRun.OnUISE -= PlaySE;
        }

        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Unregister(this);
        }
    }
}
