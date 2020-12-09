using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;

    public Transform generationPoint;

    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public GameObject[] thePlatforms;

    private int platformSelector;

    // Start is called before the first frame update
    void Start()
    {
        // the size of the platform
        platformWidth = thePlatform.GetComponent<BoxCollider>().size.y;
    }

    // Update is called once per frame
    void Update()
    {

        // a new platform spawns when it passes the generation point
        if(transform.position.y < generationPoint.position.y)
        {

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            transform.position = new Vector3(transform.position.x, transform.position.y + platformWidth + distanceBetween, transform.position.z);

            platformSelector = Random.Range(0, thePlatforms.Length);

            Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);
        }
    }
}
