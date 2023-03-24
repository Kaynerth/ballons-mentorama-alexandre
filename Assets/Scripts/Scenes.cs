using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _uiClick;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnClickNewGame()
    {
        _audioSource.PlayOneShot(_uiClick);
        SceneManager.LoadScene("InGameScene");
    }

    public void OnClickRecords()
    {
        _audioSource.PlayOneShot(_uiClick);
        SceneManager.LoadScene("RecordsScene");
    }

    public void OnClickMainMenu()
    {
        _audioSource.PlayOneShot(_uiClick);
        SceneManager.LoadScene("MainMenuScene");
    }

    public void OnClickExitGame()
    {
        _audioSource.PlayOneShot(_uiClick);
        Application.Quit();
    }
}
