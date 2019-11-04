using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    [SerializeField] GameObject toast;
    [SerializeField] GameObject target;
    [SerializeField] float destroyDelay;

    [SerializeField] AudioSource soundToastLand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider toast) //On collision of toast with target
    {
        soundToastLand.Play();
        Debug.Log("Collision detected");
    }

}
