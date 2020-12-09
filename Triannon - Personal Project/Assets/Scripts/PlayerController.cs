using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 4.0f;
    private float xrange = 10;
    private Rigidbody playerRb;

    public bool hasPowerUp;
    public GameObject powerUpIndicator;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Controls Player movement side to side
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        // player jumps when space key pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * 6, ForceMode.Impulse);
        }

        // keeps player within bounds
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        powerUpIndicator.transform.position = new Vector3(0, 9.0f, 0); 
    }

    // Makes it so the player knows it has a powerup
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Debug.Log("PowerUp = " + hasPowerUp);
            Destroy(collider.gameObject);
            StartCoroutine(PowerUpCountDown());
            powerUpIndicator.gameObject.SetActive(true);
        }

        // Gets rid of powerup after a certain amount of seconds
        IEnumerator PowerUpCountDown()
        {
            yield return new WaitForSeconds(7); hasPowerUp = false;
            powerUpIndicator.gameObject.SetActive(false);
        }
    }
}
