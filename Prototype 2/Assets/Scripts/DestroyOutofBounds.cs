using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerbounds = -10f;

    private void Awake()
    {
        Time.timeScale = 1:
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy any Object entering the topbounds
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        // Destroy any Objects entering the lowerbounds
        else if(transform.position.z < lowerbounds)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
        
    }
}
