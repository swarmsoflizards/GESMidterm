using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //Need to reference TextMesh Pro

public class TimerUI : MonoBehaviour
{
    
    [SerializeField] TMP_Text timerLabel; //Assign UI label to time
    [SerializeField] int timeLeft = 60; //Initial time left

    [SerializeField] GameObject endMenu; //Define end screen
    [SerializeField] TMP_Text endLabel; //Define end text

    private void Start()
    {
        endMenu.SetActive(false); //Hide end menu
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
            if (timeLeft > 0) //If there is time left
            {
                timeLeft--; //Subtract variable
            }
            else if (timeLeft <= 0) //If time runs out
            {
                endMenu.SetActive(true); //Show end screen
                endLabel.text = ("You've run out of time!");
            }
        }
    }
}
