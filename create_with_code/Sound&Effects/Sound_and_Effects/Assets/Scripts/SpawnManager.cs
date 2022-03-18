using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;


    public GameObject obstaclePrefab;
    private Vector3 pos = new Vector3(25f, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    


    void SpawnObstacle()
    {
        if(!playerControllerScript.gameOver)
        {
             Instantiate(obstaclePrefab, pos, obstaclePrefab.transform.rotation);

        }

    }

}
