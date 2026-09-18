using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TitleUISE : MonoBehaviour, ISeSetable
{
    private void Start()
    {
        if (SeVolumeController.Instance != null)
        {
            SeVolumeController.Instance.Register(this);
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
