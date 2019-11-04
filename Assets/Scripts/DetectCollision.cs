using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    [SerializeField] GameObject toast;
    [SerializeField] GameObject target;
    [SerializeField] float destroyDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //On collision of toast with target
    {
        Debug.Log("Collision detected");
    }

    //void DestroyTargetAndToast() //Destroy after specified seconds
    //{
    //    Destroy(target, destroyDelay); //Destroy target
    //}

}
