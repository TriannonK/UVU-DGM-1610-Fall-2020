using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
using System;

public class ArrowContoller : MonoBehaviour
{
    public float speed = 10.0f;
    
    private float zrange = 35;
   
    private Rigidbody arrowsRb;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        arrowsRb = this.GetComponent<Rigidbody>();

        // move arrows forward
        arrowsRb.velocity = new Vector3(0, 0, random.Next(15,25));

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

// Update is called once per frame
void Update()
    {
        // destroys arrow prefabs when they leave the boundaries
        if(transform.position.z > zrange)
        {
            Destroy(gameObject);
        }
    }

    
}
