using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] GameObject targetPrefab; //Assign target prefab to be instnatiated
    [SerializeField] float maxTargetNumber; //Set max number of targets in scene
    [SerializeField] float spawnRangeMaxX; //Set range max x
    [SerializeField] float spawnRangeMinX; //Set range min x
    [SerializeField] float spawnRangeMaxZ; //Set range max z
    [SerializeField] float spawnRangeMinZ; //Set range min z
    [SerializeField] float spawnY; //Set spawn y value

    private float targetsInScene; //Set var current number of targets in scene

    void Update()
    {
        if (targetsInScene != maxTargetNumber) //Check if plates in scene is equal to max plates
        {
            SpawnTarget(); //Spawn target
        }
        else if (targetsInScene == maxTargetNumber)
        {
            //Don't spawn target
        }
        
    }
    void SpawnTarget() //Spawn plate prefab
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeMinX, spawnRangeMaxX), spawnY, Random.Range(spawnRangeMinZ, spawnRangeMaxZ)); //Set spawn position
        Instantiate(targetPrefab, spawnPos, Quaternion.identity); //Instantiate plate
        targetsInScene++; //Add to plate counter float
    }
}
