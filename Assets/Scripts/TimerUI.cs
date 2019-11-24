using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //Need to reference TextMesh Pro

public class TimerUI : MonoBehaviour
{
    
    [SerializeField] TMP_Text timerLabel; //Assign UI label to time
    [SerializeField] int timeLeft = 60; //Initial time left

    private void Start()
    {
        StartCoroutine("Countdown"); //Start countdown coroutine
        Time.timeScale = 1; //Make sure that time scale is right
    }

    void Update()
    {
        timerLabel.text = ("" + timeLeft); //Write countdown to canvas
    }

    IEnumerator Countdown() //Countdown coroutine
    {
        while (true)
        {
            yield return new WaitForSeconds(1); //Return every second
            timeLeft--; //Subtract variable
        }
    }
}
