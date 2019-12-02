﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Need to reference TextMesh Pro

public class ToastLauncher : MonoBehaviour
{
    [SerializeField] GameObject toastPrefab; //Set toast prefab as GameObject
    [SerializeField] TMP_Text pointsLabel; //Assign points label
    [SerializeField] float launchForce = 5f; //Set launch force
    [SerializeField] float launchPerSecond = 2; //Limit launch per second
    [SerializeField] float delayDestroy = 10; //Set length of delay before toast destroy
    bool canLaunch = true; //Set allowed to launch

    [SerializeField] AudioSource soundToastLaunch; //Set toast launch sound

    void Update()
    {
        if (canLaunch && Input.GetKeyDown(KeyCode.Space)) //Launch on spacebar
        {
            soundToastLaunch.Play(); //Play toast launch sound
            GameObject toast = Instantiate(toastPrefab, transform.position, Quaternion.identity); //Instantiate toast
            Rigidbody rb = toast.GetComponent<Rigidbody>(); //Get toast Rigidbody

            Vector3 direction = Quaternion.Euler(15, 0, 0) * transform.forward; //Define launch force
            rb.AddForce(direction * launchForce, ForceMode.Impulse); //Apply launch force
            canLaunch = false; //Set can launch to false
            Destroy(toast, delayDestroy); //Destroy toast after length of time

            Invoke("EnableLaunch", 1 / launchPerSecond); //Apply launch per second
        }
    }

    void EnableLaunch()
    {
        canLaunch = true; //Allow launch
    }
}
