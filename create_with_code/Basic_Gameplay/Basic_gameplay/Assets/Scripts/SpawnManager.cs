using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private int rangeX = 15;
    private int rangeZ= 8;
    private float startdelay = 2f;
    private float spawnInterval = 1.5f;
    //private float spawnIntervalSide = 2.5f;

    


    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimalsTop", startdelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalsLeft", startdelay, Random.Range(2.5f, 6f));
        InvokeRepeating("SpawnRandomAnimalsRight", startdelay, Random.Range(2.5f, 6f));
    }
    
    void SpawnRandomAnimalsTop()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length/2);
        Vector3 randomPos = new Vector3(Random.Range(-rangeX, rangeX), 0, 25);
        Instantiate(animalsPrefabs[animalIndex], randomPos, animalsPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalsLeft()
    {
        int animalIndex = Random.Range(animalsPrefabs.Length/2, animalsPrefabs.Length);
        Vector3 randomPos = new Vector3(-25, 0, Random.Range(0, rangeZ));
        Instantiate(animalsPrefabs[animalIndex], randomPos, Quaternion.Euler(0f, 90, 0f));
       
    }

    void SpawnRandomAnimalsRight()
    {
        int animalIndex = Random.Range(animalsPrefabs.Length / 2, animalsPrefabs.Length);
        Vector3 randomPos = new Vector3(25, 0, Random.Range(0, rangeZ));
        Instantiate(animalsPrefabs[animalIndex], randomPos, Quaternion.Euler(0f,270,0f) );
    }


}
