using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab; //Assign target prefab to be instnatiated
    [SerializeField] float spawnRangeMaxX; //Set range max x
    [SerializeField] float spawnRangeMinX; //Set range min x
    [SerializeField] float spawnRangeMaxZ; //Set range max z
    [SerializeField] float spawnRangeMinZ; //Set range min z
    [SerializeField] float startDelay = 2; //Set delay
    [SerializeField] float spawnInternal = 1.5f; //

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", startDelay, spawnInternal); //Keep spawning new targets
    }
    void SpawnTarget()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeMinX, spawnRangeMaxX), 0, Random.Range(spawnRangeMinZ, spawnRangeMaxZ)); //Set spawn position

        Instantiate(targetPrefab, spawnPos, Quaternion.identity); //Instantiate plate
    }
}
