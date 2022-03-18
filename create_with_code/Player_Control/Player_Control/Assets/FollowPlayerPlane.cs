using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerPlane : MonoBehaviour
{
    public GameObject Plane;
    Vector3 offset = new Vector3(30, 0, 2);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Plane.transform.position + offset;
        
    }
}
