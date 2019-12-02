using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Need to reference TextMesh Pro

public class DetectCollision : MonoBehaviour
{
    //[SerializeField] TMP_Text pointsLabel; //Assign UI label to points
    [SerializeField] int points = 0; //Initial points
    //[SerializeField] float destroyDelay;

    [SerializeField] AudioSource soundToastLand; //Play sound

    //public TMP_Text pointsLabel;

    private void Start()
    {
        ////pointsLabel = gameObject.AddComponent<TextMeshPro>();
        //TextMeshPro pointsText = GetComponent<TextMeshPro>();
        //pointsText.text = "Points: " + points;
    }

    // Update is called once per frame
    void Update()
    {
        //pointsLabel.text = ("" + points); //Write points to canvas
    }

    private void OnCollisionEnter(Collision collision) //On collision of toast with target
    {
        soundToastLand.Play();
        points++; //Add points
        Debug.Log("Collision detected");
    }

    //void DestroyTargetAndToast() //Destroy after specified seconds
    //{
    //    Destroy(target, destroyDelay); //Destroy target
    //}

}
