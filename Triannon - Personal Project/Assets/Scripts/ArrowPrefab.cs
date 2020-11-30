using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPrefab : MonoBehaviour

{
    public float speed = 10.0f;
    private float xrange = 10;
    private Rigidbody arrowsRb;

    // Start is called before the first frame update
    void Start()
    {
        arrowsRb = this.GetComponent<Rigidbody>();

        // move arrows right to left
        arrowsRb.velocity = new Vector2(-speed, 0);

       
    }

    // Update is called once per frame
    void Update()
    {
        // destroys arrows if they leave the boundaries of the game
        if (transform.position.x < -xrange)
        {
            Destroy(gameObject);
        }
    }
}
