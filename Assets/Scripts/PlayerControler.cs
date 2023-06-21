using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed=0;
    private float horizontalInput;
    private float verticalInput;
    
    private float xRange = 15.0f;
    private float zMin = 0.5f;
    
    private float moveLimit = 15;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPos;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        // Controll the player to movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);

        // Player's range of movement
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-moveLimit, transform.position.y,transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(moveLimit,transform.position.y,transform.position.z);
        }

        if(transform.position.z > xRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,moveLimit);
        }
        if(transform.position.z < -zMin)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,-zMin);
        }
        
        // Shoot bullets
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab,projectileSpawnPos.position,projectilePrefab.transform.rotation);
        } 

        // GameLost
        if(gameManager.lives == 0)
        {
            Destroy(gameObject);
        }
    }
}
