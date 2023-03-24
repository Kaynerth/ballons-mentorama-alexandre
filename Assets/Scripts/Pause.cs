using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] Image _pausePanel;
    [SerializeField] Image _pauseBackground;
    [SerializeField] Image _pauseText;

    [SerializeField] TMP_Text _pauseMusicText;
    [SerializeField] TMP_Text _pauseEffectsText;

    [SerializeField] Slider _pauseMusicSlider;
    [SerializeField] Slider _pauseEffectsSlider;

    [SerializeField] Button _pauseMainMenuButton;
    [SerializeField] Button _pauseContinueButton;

    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _uiClick;

    void Start()
    {
        _pausePanel.gameObject.SetActive(false);
        _pauseBackground.gameObject.SetActive(false);
        _pauseText.gameObject.SetActive(false);
        _pauseMusicText.gameObject.SetActive(false);
        _pauseEffectsText.gameObject.SetActive(false);
        _pauseMusicSlider.gameObject.SetActive(false);
        _pauseEffectsSlider.gameObject.SetActive(false);
        _pauseMainMenuButton.gameObject.SetActive(false);
        _pauseContinueButton.gameObject.SetActive(false);
    }

    public void PauseMenu()
    {
        _audioSource.PlayOneShot(_uiClick);
        Time.timeScale = 0;

        _pausePanel.gameObject.SetActive(true);
        _pauseBackground.gameObject.SetActive(true);
        _pauseText.gameObject.SetActive(true);
        _pauseMusicText.gameObject.SetActive(true);
        _pauseEffectsText.gameObject.SetActive(true);
        _pauseMusicSlider.gameObject.SetActive(true);
        _pauseEffectsSlider.gameObject.SetActive(true);
        _pauseMainMenuButton.gameObject.SetActive(true);
        _pauseContinueButton.gameObject.SetActive(true);
    }

    public void Unpause()
    {
        _audioSource.PlayOneShot(_uiClick);
        Time.timeScale = 1;

        _pausePanel.gameObject.SetActive(false);
        _pauseBackground.gameObject.SetActive(false);
        _pauseText.gameObject.SetActive(false);
        _pauseMusicText.gameObject.SetActive(false);
        _pauseEffectsText.gameObject.SetActive(false);
        _pauseMusicSlider.gameObject.SetActive(false);
        _pauseEffectsSlider.gameObject.SetActive(false);
        _pauseMainMenuButton.gameObject.SetActive(false);
        _pauseContinueButton.gameObject.SetActive(false);
    }
}
