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
    //[SerializeField] float startDelay = 2; //Set delay
    //[SerializeField] float spawnInternal = 1.5f; //

    private float targetsInScene; //Set var current number of targets in scene
    bool spawnPlates = true;
    

    void Update()
    {
        if (targetsInScene != maxTargetNumber) //Check if spawn plates is possible
        {
            SpawnTarget(); //Spawn target
            //if (targetsInScene == maxTargetNumber) //If number of plates is at max
            //{
            //    spawnPlates = false; //Don't allow more plates to spawn
            //}
            //else if (targetsInScene != maxTargetNumber) //If number of plates is less than max
            //{
            //    targetsInScene = +1; //Add to targetsInScene
            //}
        }
        else if (targetsInScene == maxTargetNumber)
        {
            //Don't spawn target
        }
        
    }
    void SpawnTarget()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeMinX, spawnRangeMaxX), 0, Random.Range(spawnRangeMinZ, spawnRangeMaxZ)); //Set spawn position
        Instantiate(targetPrefab, spawnPos, Quaternion.identity); //Instantiate plate
        targetsInScene++;
    }
}
