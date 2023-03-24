using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] HighScore _scoreManager;

    [Header("Ballons")]
    [SerializeField] GameObject _ballon1;
    [SerializeField] GameObject _ballon2;

    [SerializeField] float _ballonSpawnCooldown;

    float _ballonSpawnTimer;

    Vector2 _ballonSpawnPosition;

    int _randomBallon;

    [Header("Player")]
    [SerializeField] TMP_Text _livesText;
    [HideInInspector] public int _lives;

    void Start()
    {
        _scoreManager._gameScore = 0;
        _scoreManager._yourScore.text = _scoreManager._gameScore.ToString();

        _lives = 3;

        _ballonSpawnTimer = Time.time;
        _randomBallon = Random.Range(0, 2);
        _ballonSpawnPosition = new Vector2(Random.Range(-1.7f, 1.7f), 6f);
    }

    void Update()
    {
        _scoreManager._yourScore.text = _scoreManager._gameScore.ToString();
        _livesText.text = _lives.ToString();

        if (Time.time > _ballonSpawnTimer + _ballonSpawnCooldown)
        {
            if (_randomBallon == 1)
            {
                Instantiate(_ballon1, _ballonSpawnPosition, Quaternion.identity);
                _ballonSpawnPosition = new Vector2(Random.Range(-1.7f, 1.7f), 6f);
                _ballonSpawnTimer = Time.time;
            }
            else
            {
                Instantiate(_ballon2, _ballonSpawnPosition, Quaternion.identity);
                _ballonSpawnPosition = new Vector2(Random.Range(-1.7f, 1.7f), 6f);
                _ballonSpawnTimer = Time.time;
            }

            _randomBallon = Random.Range(0, 2);
        }

        if (_scoreManager._gameScore >= 10)
        {
            _ballonSpawnCooldown = 1.7f;
        }

        if (_scoreManager._gameScore >= 25)
        {
            _ballonSpawnCooldown = 1.5f;
            _ballon1.GetComponent<Rigidbody>().drag = 7;
            _ballon2.GetComponent<Rigidbody>().drag = 5;
        }

        if (_scoreManager._gameScore >= 50)
        {
            _ballonSpawnCooldown = 1.3f;
        }

        if (_scoreManager._gameScore >= 100)
        {
            _ballonSpawnCooldown = 1.0f;
            _ballon1.GetComponent<Rigidbody>().drag = 5;
            _ballon2.GetComponent<Rigidbody>().drag = 3;
        }

        if (_scoreManager._gameScore >= 200)
        {
            _ballonSpawnCooldown = 0.7f;
        }

        if (_scoreManager._gameScore >= 300)
        {
            _ballonSpawnCooldown = 0.5f;
        }

        if (_scoreManager._gameScore >= 500)
        {
            _ballon1.GetComponent<Rigidbody>().drag = 3;
            _ballon2.GetComponent<Rigidbody>().drag = 1;
        }

        if (_scoreManager._gameScore >= 500)
        {
            _ballonSpawnCooldown = 0.3f;
            _ballon1.GetComponent<Rigidbody>().drag = 2;
        }

        if (_lives == 0)
        {
            _scoreManager.ScoreUpdate();
            PlayerPrefs.SetInt("PlayerScore", _scoreManager._gameScore);
            SceneManager.LoadScene("ScoreScene");
        }

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("Ballon1"))
                    {
                        hit.collider.GetComponent<Ballons>().ScoreUpBallon1();
                    }
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("Ballon2"))
                    {
                        hit.collider.GetComponent<Ballons>().ScoreUpBallon2();
                    }
                }
            }
        }
    }
}
