using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balls;
    void Start()
    {
        InvokeRepeating("SpawnRandomBalls", 1.5f,Random.Range(3f,5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalls()
    {
        int randomBall = Random.Range(0, balls.Length);
        int randomPos = Random.Range(-32, 10);
        Instantiate(balls[randomBall], new Vector3(randomPos, 30 , 1) , Quaternion.identity);
    }
}
