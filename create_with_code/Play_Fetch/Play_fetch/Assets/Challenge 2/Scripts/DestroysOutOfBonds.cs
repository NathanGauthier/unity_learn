using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroysOutOfBonds : MonoBehaviour
{
    private int leftLimit = -42;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
