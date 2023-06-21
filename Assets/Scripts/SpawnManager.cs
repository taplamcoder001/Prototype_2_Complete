using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float sideSpawnMaxZ = 15;
    private float sideSpawnMinZ = 0;
    private float startDelay = 2;
    private Vector3 rotationRight= new Vector3(0,-90,0);
    private Vector3 rotationLeft= new Vector3(0,90,0);
    private float spawnIntertal = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Automatic spawn animals
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnIntertal);
        InvokeRepeating("SpawnRightAnimal",startDelay,spawnIntertal);
        InvokeRepeating("SpawnLeftAnimal",startDelay,spawnIntertal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        // Method spawn random pos and random kind of animals
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,sideSpawnMaxZ);

        Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX,0,Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
        
        Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(rotationRight));
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnRangeX,0,Random.Range(sideSpawnMinZ,sideSpawnMaxZ));
        
        Instantiate(animalPrefabs[animalIndex],spawnPos,Quaternion.Euler(rotationLeft));
    }
}
