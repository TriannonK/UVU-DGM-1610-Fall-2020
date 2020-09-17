using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propellor : MonoBehaviour
{

    public float verticalInput;
    public float speed;
    public float horizontalInput;
    public float rotationSpeed;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // make the propellor spin
        transform.Rotate(transform.forward, 40);
    }
}
