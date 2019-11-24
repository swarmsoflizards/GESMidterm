using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerUI : MonoBehaviour
{
    
    [SerializeField] TMP_Text timerLabel; //Assign UI label to time
    //private float time; //Time variable
    [SerializeField] int timeLeft = 60; //Initial time left

    private void Start()
    {
        StartCoroutine("Countdown"); //Start countdown coroutine
        Time.timeScale = 1; //Make sure that time scale is right
    }


    // Update is called once per frame
    void Update()
    {

        timerLabel.text = ("" + timeLeft); //Write countdown to canvas

        //time += Time.deltaTime;

        //var minutes = time / 60; //Divide guiTime by 60 to get minutes
        //var seconds = time % 60; //Euclidean divide to get seconds
        ////var fraction = (time * 100) % 100;

        //timerLabel.text = string.Format("{0:00} : {1:00}", minutes, seconds); //Update label text

    }

    IEnumerator Countdown() //Countdown coroutine
    {
        while (true)
        {
            yield return new WaitForSeconds(1); //
            timeLeft--; //Subtract variable
        }
    }
}
