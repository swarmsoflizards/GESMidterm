using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastFly : MonoBehaviour
{
    [SerializeField] float flySpeed = 20; //Set toast flying speed

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * flySpeed); //Apply toast flying speed
    }
}
