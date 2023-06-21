using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectcCollision : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            if(gameManager.lives ==0 )
            {
                Destroy(gameObject);
            }
            Destroy(gameObject);
        }
        else if(other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }
    }
}
