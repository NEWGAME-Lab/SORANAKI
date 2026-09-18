using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VolumeUIController : MonoBehaviour
{
    [SerializeField] private Slider masterVolumeSlider;
    [SerializeField] private Slider bgmVolumeSlider;
    [SerializeField] private Slider seVolumeSlider;

    AudioSettings audioSettings;

    private void Awake()
    {


    }

    private void Start()
    {
        audioSettings = AudioSettings.Instance;
        if (audioSettings == null)
        {
            Debug.LogError("AudioSettings instance is null.");
            return;
        }
        SetupSliders();
    }

    private void SetupSliders()
    {
        if(masterVolumeSlider != null)
        {
            masterVolumeSlider.value = audioSettings.GetMasterVolume();
        }
        if(bgmVolumeSlider != null)
        {
            bgmVolumeSlider.value = audioSettings.GetBGMVolume();
        }
        if(seVolumeSlider != null)
        {
            seVolumeSlider.value = audioSettings.GetSEVolume();
        }
    }


    /// <summary>
    /// UIEventTriggerのPointer Up
    /// </summary>
    /// <param name="value"></param>
    public void OnMasterVolumeSliderChanged()
    {
        OnChangeMasterVolume(masterVolumeSlider.value);
    }

    public void OnBGMVolumeSliderChanged()
    {
        OnChangeBGMVolume(bgmVolumeSlider.value);
    }

    public void OnSEVolumeSliderChanged()
    {
        OnChangeSEVolume(seVolumeSlider.value);
    }



    private void OnChangeMasterVolume(float value)
    {
        audioSettings.SetMasterVolume(value);
    }

    private void OnChangeBGMVolume(float value)
    {
        audioSettings.SetBGMVolume(value);
    }

    private  void OnChangeSEVolume(float value)
    {
        audioSettings.SetSEVolume(value);
        Debug.Log("SE Volume changed to: " + value);
    }

}
