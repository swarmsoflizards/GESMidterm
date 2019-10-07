using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastLauncher : MonoBehaviour
{
    public GameObject toastPrefab; //Set toast prefab as GameObject

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch toast from toaster
            Instantiate(toastPrefab, transform.position, toastPrefab.transform.rotation); //Launch from toaster's position
        }
    }

}
