using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastLauncher : MonoBehaviour
{
    [SerializeField] GameObject toastPrefab; //Set toast prefab as GameObject
    [SerializeField] float launchForce = 5f; //Set launch force
    [SerializeField] float launchPerSecond = 2; //Limit launch per second
    bool canLaunch = true; //Set allowed to launch

    // Update is called once per frame
    void Update()
    {
        if (canLaunch && Input.GetKeyDown(KeyCode.Space)) //Launch on spacebar
        {
            //Instantiate(toastPrefab, transform.position, toastPrefab.transform.rotation); //Launch from toaster's position
            GameObject toast = Instantiate(toastPrefab, transform.position, Quaternion.identity);
            Rigidbody rb = toast.GetComponent<Rigidbody>(); //Get toast Rigidbody

            Vector3 direction = Quaternion.Euler(15, 0, 0) * transform.forward; //Define launch force
            rb.AddForce(direction * launchForce, ForceMode.Impulse); //Apply launch force
            canLaunch = false;

            Invoke("EnableLaunch", 1 / launchPerSecond); //Apply launch per second
        }
    }

    void EnableLaunch()
    {
        canLaunch = true; //Allow launch
    }

}
