using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerUI : MonoBehaviour
{
    
    [SerializeField] TMP_Text timerLabel; //Assign UI label to time
    private float time; //Time variable

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        var minutes = time / 60; //Divide guiTime by 60 to get minutes
        var seconds = time % 60; //Euclidean divide to get seconds
        //var fraction = (time * 100) % 100;

        timerLabel.text = string.Format("{0:00} : {1:00}", minutes, seconds); //Update label text

    }
}
