using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision Toast) //On collision
    {
        if (Toast.gameObject.tag == "Toast") //If the colliding object is tagged "Toast"
        {
            print("Detected collision between " + gameObject.name + " and " + Toast.collider.name); //Print to console
            PersistentScoreManager.Instance.Score++; //Add to score
        }
    }

}
