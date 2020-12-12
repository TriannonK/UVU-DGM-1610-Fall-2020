using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int speed = 20;

    [SerializeField] float turnSpeed = 100;

    private float hInput;

    private float fInput;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        // Move the Vehicle Forward based off vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * fInput * speed);

        //Rotate the Vehicle left and right based off horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * hInput * turnSpeed);
    }
}
