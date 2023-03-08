using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{


    public GameObject oldCar;

    void Start()
    {

    }


void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        //this instantiates cars to fly when spacebar is pressed    
        for (int i = 0; i < 70; i++)
        {
            GameObject carobj = Instantiate(oldCar, gameObject.transform.position, Quaternion.identity);
            float rotXAmount = Random.Range(-89, -10);
            float rotYAmount = Random.Range(0, 360);
            carobj.transform.Rotate(rotXAmount, rotYAmount, 0);
            Rigidbody forCar = carobj.GetComponent<Rigidbody>();
            forCar.AddForce(carobj.transform.forward * 1000);

            Destroy(carobj, 2f);
        }

    }
}
}