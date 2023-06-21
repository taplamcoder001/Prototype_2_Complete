using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLives(int value)
    {
        lives += value;
        if(lives <= 0)
        {
            Debug.Log("GameOver");
            lives =0;
        }
        Debug.Log("Live = " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score:" + score);
    }
}
