using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DetectCollision : MonoBehaviour
{
    public GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        // when arrow collides with player the game stops player and the game over text appears
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            gameManager.GameOver();
        }

    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
