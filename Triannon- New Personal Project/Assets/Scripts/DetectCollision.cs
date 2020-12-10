using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }

   

}
