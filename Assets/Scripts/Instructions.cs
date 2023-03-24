using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Instructions : MonoBehaviour
{
    [SerializeField] Image _instructionsPanel;
    [SerializeField] Image _instructionsBackground;
    [SerializeField] Image _instructionsTitleText;
    [SerializeField] Image _instructionsBallon1;
    [SerializeField] Image _instructionsBallon2;

    [SerializeField] TMP_Text _instructionsText;
    [SerializeField] TMP_Text _instructionsText2;

    [SerializeField] Button _instructionsBackButton;

    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _uiClick;

    void Start()
    {
        _instructionsPanel.gameObject.SetActive(false);
        _instructionsBackground.gameObject.SetActive(false);
        _instructionsTitleText.gameObject.SetActive(false);
        _instructionsBallon1.gameObject.SetActive(false);
        _instructionsBallon2.gameObject.SetActive(false);
        _instructionsText.gameObject.SetActive(false);
        _instructionsText2.gameObject.SetActive(false);
        _instructionsBackButton.gameObject.SetActive(false);
    }

    public void InstructionsMenu()
    {
        _audioSource.PlayOneShot(_uiClick);
        _instructionsPanel.gameObject.SetActive(true);
        _instructionsBackground.gameObject.SetActive(true);
        _instructionsTitleText.gameObject.SetActive(true);
        _instructionsBallon1.gameObject.SetActive(true);
        _instructionsBallon2.gameObject.SetActive(true);
        _instructionsText.gameObject.SetActive(true);
        _instructionsText2.gameObject.SetActive(true);
        _instructionsBackButton.gameObject.SetActive(true);
    }

    public void OnClickBackButton()
    {
        _audioSource.PlayOneShot(_uiClick);
        _instructionsPanel.gameObject.SetActive(false);
        _instructionsBackground.gameObject.SetActive(false);
        _instructionsTitleText.gameObject.SetActive(false);
        _instructionsBallon1.gameObject.SetActive(false);
        _instructionsBallon2.gameObject.SetActive(false);
        _instructionsText.gameObject.SetActive(false);
        _instructionsText2.gameObject.SetActive(false);
        _instructionsBackButton.gameObject.SetActive(false);
    }
}
