using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowContoller : MonoBehaviour
{
    public float speed = 10.0f;

    private float zrange = 25;
   
    private Rigidbody arrowsRb;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
         arrowsRb = this.GetComponent<Rigidbody>();

        // move arrows forward
        arrowsRb.velocity = new Vector3(0, 0, speed);

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

// Update is called once per frame
void Update()
    {
        if(transform.position.z < -zrange)
        {
            Destroy(gameObject);
        }
    }
}
