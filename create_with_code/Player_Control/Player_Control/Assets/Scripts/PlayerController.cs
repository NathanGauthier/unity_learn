using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0, 50)]
    int speed = 20;

    
    private float turnSpeed = 20f;

    private float horizontalInput;
    private float verticalInput;
    void Start()
    {

    }


    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicule 
        transform.Translate(Vector3.forward * speed * verticalInput *  Time.deltaTime)  ;
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}