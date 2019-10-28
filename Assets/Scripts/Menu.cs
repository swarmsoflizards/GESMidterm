using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu; //Define menu screen
    [SerializeField] GameObject creditsMenu; //Define credits screen

    public void StartGame()
    {
        mainMenu.SetActive(false);
    }

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true); //Show main menu
        creditsMenu.SetActive(false); //Hide credits screen
    }

    public void ShowCreditsMenu()
    {
        mainMenu.SetActive(false); //Hide main menu
        creditsMenu.SetActive(true); //Show credits screen
    }

    public void Quit()
    {
        Application.Quit(); //Quit game
    }
}
