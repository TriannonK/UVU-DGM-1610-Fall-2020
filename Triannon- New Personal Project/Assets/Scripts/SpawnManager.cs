using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float respawnTime = 1.0f;
    private Vector3 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(arrowWave());
    }

    private void spawnArrows()
    {
        GameObject a = Instantiate(arrowPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), 0, screenBounds.z * -2);

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator arrowWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnArrows();
        }
    }
} 
