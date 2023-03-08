using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    float moveSpeed = 5f;
    float rotateSpeed = 75f;
    //public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
      //  gm = GameObject.Find("GameManager").GetComponent<GameManager>();


    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveSpeed * vAxis, Space.World);

        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0);





    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("pin"))
        {
           // gm.IncrementPlayerScore();
            Destroy(other.gameObject);


        }


    }
}
