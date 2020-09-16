using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;

    private float turnSpeed = 100;

    private float hInput;

    private float fInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        // Move the Vehicle Forward base off vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * fInput * speed);

        //Rotate the Vehicle left and right based off horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * hInput* turnSpeed);
    }
}
