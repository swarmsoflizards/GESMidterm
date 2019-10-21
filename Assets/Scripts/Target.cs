using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject targetPrefab; //Assign target prefab to be instnatiated
    public float spawnRangeX; //Set range x
    public float spawnRangeZ; //Set range z
    public float startDelay = 2; //Set delay
    public float spawnInternal = 1.5f; //

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", startDelay, spawnInternal); //Keep spawning new targets
    }
    void SpawnTarget()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        Instantiate(targetPrefab, spawnPos, Quaternion.identity); //Instantiate plate
    }
}
