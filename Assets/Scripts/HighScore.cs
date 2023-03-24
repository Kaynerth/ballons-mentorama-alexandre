using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TMP_Text _yourScore;

    [SerializeField] TMP_Text _score1;
    [SerializeField] TMP_Text _score2;
    [SerializeField] TMP_Text _score3;
    [SerializeField] TMP_Text _score4;
    [SerializeField] TMP_Text _score5;

    public int _gameScore;

    int _score1Valor;
    int _score2Valor;
    int _score3Valor;
    int _score4Valor;
    int _score5Valor;

    void Start()
    {
        if (_score1 != null && _score2 != null && _score3 != null && _score4 != null && _score5 != null)
        {
            _score1.text = PlayerPrefs.GetInt("Score1", 0).ToString();
            _score2.text = PlayerPrefs.GetInt("Score2", 0).ToString();
            _score3.text = PlayerPrefs.GetInt("Score3", 0).ToString();
            _score4.text = PlayerPrefs.GetInt("Score4", 0).ToString();
            _score5.text = PlayerPrefs.GetInt("Score5", 0).ToString();
        }

        if (_yourScore != null)
        {
            _yourScore.text = PlayerPrefs.GetInt("PlayerScore", 0).ToString();
        }

        _score1Valor = PlayerPrefs.GetInt("Score1", 0);
        _score2Valor = PlayerPrefs.GetInt("Score2", 0);
        _score3Valor = PlayerPrefs.GetInt("Score3", 0);
        _score4Valor = PlayerPrefs.GetInt("Score4", 0);
        _score5Valor = PlayerPrefs.GetInt("Score5", 0);
    }

    public void ScoreUpdate()
    {
        if (_gameScore > _score1Valor)
        {
            if (_score2Valor < _score1Valor)
            {
                if (_score3Valor < _score2Valor)
                {
                    if (_score4Valor < _score3Valor)
                    {
                        _score5Valor = _score4Valor;
                        PlayerPrefs.SetInt("Score5", _score5Valor);

                        _score4Valor = _score3Valor;
                        PlayerPrefs.SetInt("Score4", _score4Valor);
                    }

                    _score3Valor = _score2Valor;
                    PlayerPrefs.SetInt("Score3", _score3Valor);
                }

                _score2Valor = _score1Valor;
                PlayerPrefs.SetInt("Score2", _score2Valor);
            }

            _score1Valor = _gameScore;
            PlayerPrefs.SetInt("Score1", _score1Valor);
        }

        else if (_gameScore < _score1Valor &&
                 _gameScore > _score2Valor)
        {
            if (_score3Valor < _score2Valor)
            {
                if (_score4Valor < _score3Valor)
                {
                    _score5Valor = _score4Valor;
                    PlayerPrefs.SetInt("Score5", _score5Valor);

                    _score4Valor = _score3Valor;
                    PlayerPrefs.SetInt("Score4", _score4Valor);
                }

                _score3Valor = _score2Valor;
                PlayerPrefs.SetInt("Score3", _score3Valor);
            }

            _score2Valor = _gameScore;
            PlayerPrefs.SetInt("Score2", _score2Valor);
        }

        else if (_gameScore < _score1Valor &&
                 _gameScore < _score2Valor &&
                 _gameScore > _score3Valor)
        {
            if (_score4Valor < _score3Valor)
            {
                _score5Valor = _score4Valor;
                PlayerPrefs.SetInt("Score5", _score5Valor);

                _score4Valor = _score3Valor;
                PlayerPrefs.SetInt("Score4", _score4Valor);
            }

            _score3Valor = _gameScore;
            PlayerPrefs.SetInt("Score3", _score3Valor);
        }

        else if (_gameScore < _score1Valor &&
                 _gameScore < _score2Valor &&
                 _gameScore < _score3Valor &&
                 _gameScore > _score4Valor)
        {
            _score5Valor = _score4Valor;
            PlayerPrefs.SetInt("Score5", _score5Valor);

            _score4Valor = _gameScore;
            PlayerPrefs.SetInt("Score4", _score4Valor);
        }

        else if (_gameScore < _score1Valor &&
                 _gameScore < _score2Valor &&
                 _gameScore < _score3Valor &&
                 _gameScore < _score4Valor &&
                 _gameScore > _score5Valor)
        {
            _score5Valor = _gameScore;
            PlayerPrefs.SetInt("Score5", _score5Valor);
        }
    }
}
