using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text _scoreText;
    public Text _gameOverText;

    int _playerScore = 0;

    public void AddScore()
    {
        _playerScore++;
        _scoreText.text = _playerScore.ToString();
    }

    public void PlayerDied()
    {
        _gameOverText.enabled = true;
        Time.timeScale = 0;
    }

}
