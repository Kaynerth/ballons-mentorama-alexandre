using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioSource _musicAudioSource;
    [SerializeField] AudioSource _effectsAudioSource;

    [SerializeField] Slider _musicSlider;
    [SerializeField] Slider _effectsSlider;

    void Start()
    {
        if (_musicSlider != null && _effectsSlider != null)
        {
            _musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
            _effectsSlider.value = PlayerPrefs.GetFloat("EffectsVolume", 0.5f);

            _musicAudioSource.volume = _musicSlider.value;
            _effectsAudioSource.volume = _effectsSlider.value;
        }
        else
        {
            _musicAudioSource.volume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
            _effectsAudioSource.volume = PlayerPrefs.GetFloat("EffectsVolume", 0.5f);
        }
    }

    public void OnMusicSliderValueChange()
    {
        _musicAudioSource.volume = _musicSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", _musicSlider.value);
    }
    public void OnEffectsSliderValueChange()
    {
        _effectsAudioSource.volume = _effectsSlider.value;
        PlayerPrefs.SetFloat("EffectsVolume", _effectsSlider.value);
    }
}
