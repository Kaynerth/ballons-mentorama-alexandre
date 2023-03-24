using UnityEngine;

public class Ballons : MonoBehaviour
{
    [SerializeField] HighScore _scoreManager;
    [SerializeField] GameManager _gameManager;

    [SerializeField] GameObject _animPrefab;

    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip _lifeLost;
    [SerializeField] AudioClip _ballonPop;

    void Start()
    {
        _scoreManager = GameObject.Find("GameManager").GetComponent<HighScore>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "LimitEdge")
        {
            _gameManager._lives -= 1;
            _audioSource.PlayOneShot(_lifeLost);
            Destroy(gameObject);
        }
    }

    public void ScoreUpBallon1()
    {
        _scoreManager._gameScore += 2;
        _audioSource.PlayOneShot(_ballonPop);
        Instantiate(_animPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void ScoreUpBallon2()
    {
        _scoreManager._gameScore += 1;
        _audioSource.PlayOneShot(_ballonPop);
        Instantiate(_animPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
