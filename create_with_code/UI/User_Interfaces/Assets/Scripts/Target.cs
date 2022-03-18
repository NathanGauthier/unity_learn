using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody rb;

    public ParticleSystem particle;

    private float minSpeed = 9 ;
    private float maxSpeed = 14;
    private float torque = 10;
    private float xRange = 4;
    private float ySpawnPos = -2f;

    public int pointValue;



    private GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(RandomForce(), ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); ;
        transform.position = RandomPos();


        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-torque, torque);
    }

    Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private void OnMouseDown()
    {
        if(gameManager.isGameOver == false)
        {
            Destroy(gameObject);
            Instantiate(particle, transform.position, particle.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if(gameObject.CompareTag("Fruit"))
        {
            gameManager.GameOver();
        }
    }

}
