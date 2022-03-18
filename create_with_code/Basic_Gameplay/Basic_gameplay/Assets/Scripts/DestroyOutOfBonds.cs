using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBonds : MonoBehaviour
{

    private float topBound = 35;
    private float lowerBound = -15f;
    private float leftBound = -30f;
    private float rightBound = 30f;




    void Update()
    {
        if(transform.position.z > topBound )
        {
            Destroy(gameObject);
        }
        else if  (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over ! ");
            Destroy(gameObject);
        }
    }
}
