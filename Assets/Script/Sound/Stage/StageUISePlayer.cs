using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class StageUISePlayer : MonoBehaviour, ISeSetable
{
    [SerializeField] private AudioClip openSe;
    [SerializeField] private AudioClip closeSe;

    [SerializeField] private StageButtonUIRun buttonUIRun;

    private AudioSource audioSource;

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

    private void PlaySE(StageSEType type)
    {
        switch (type)
        {
            case StageSEType.SettingButton:
                audioSource.PlayOneShot(openSe);
                break;
            
            case StageSEType.backButton:
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

        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Unregister(this);
        }
    }
}