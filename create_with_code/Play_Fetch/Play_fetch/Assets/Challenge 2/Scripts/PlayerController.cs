using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject dog;
    bool canInstanciateDog = true;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(canInstanciateDog==true)
            {
                StartCoroutine("Wait");
            }
            
        }


    }

    IEnumerator Wait()
    {
        canInstanciateDog = false;
        Instantiate(dog, transform.position, dog.gameObject.transform.rotation); 
        yield return new WaitForSeconds(0.75f);
        canInstanciateDog = true;


    }
}
