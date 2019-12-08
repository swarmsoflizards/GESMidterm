using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collisionInfo)
    {
        print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
    }

}
