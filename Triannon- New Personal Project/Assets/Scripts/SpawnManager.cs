using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] arrowPrefab;
    public int arrowIndex;
    public float spawnRangeX = 10;
    public float spawnPosZ = -25;
    public float startDelay, spawnInterval;
    
    

    // Start is called before the first frame update
    void Start()
    {
        // spawns the arrows from the bottome of the screen
        InvokeRepeating("SpawnArrows", startDelay, spawnInterval);
    }

    private void SpawnArrows()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int arrowIndex = Random.Range(0, arrowPrefab.Length);
        Debug.Log(arrowIndex);
        Instantiate(arrowPrefab[arrowIndex], spawnPos, arrowPrefab[arrowIndex].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }

    
} 
