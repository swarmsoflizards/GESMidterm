using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab; //Assign target prefab to be instnatiated
    [SerializeField] float maxTargetNumber; //Set max number of targets in scene
    [SerializeField] float spawnRangeMaxX; //Set range max x
    [SerializeField] float spawnRangeMinX; //Set range min x
    [SerializeField] float spawnRangeMaxZ; //Set range max z
    [SerializeField] float spawnRangeMinZ; //Set range min z
    [SerializeField] float startDelay = 2; //Set delay
    [SerializeField] float spawnInternal = 1.5f; //

    private float targetsInScene; //Set var max number of targets in scene

    void Update()
    {
        if (targetsInScene <= maxTargetNumber) //Check against max number of targets
        {
            SpawnTarget(); //Spawn target
            targetsInScene = +1; //Add to targetsInScene
        }
        else
        {
            //Don't spawn target
        }
        
    }
    void SpawnTarget()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeMinX, spawnRangeMaxX), 0, Random.Range(spawnRangeMinZ, spawnRangeMaxZ)); //Set spawn position
        Instantiate(targetPrefab, spawnPos, Quaternion.identity); //Instantiate plate
    }
}
