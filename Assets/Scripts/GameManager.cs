using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;
    public TextMeshProUGUI gameoverText,scoreText,livesText;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        livesText.text = "Live: " + lives;
    }

    public void AddLives(int value)
    {
        lives += value;
        if(lives == 0)
        {
            lives =0;
            gameoverText.gameObject.SetActive(true);
            PauseGame();
        }
        livesText.text = "Live: " + lives;
    }
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }
}
