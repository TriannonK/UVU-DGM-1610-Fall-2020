using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;

    // Start is called before the first frame update
    void Start()
    {
        // Point at which the platforms will pass and be destroyed
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        // destroys platform when it passes destruction point
        if(transform.position.y < platformDestructionPoint.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
