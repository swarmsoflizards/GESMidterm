using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene"); //Load game scene
    }

    public void LoadMenuScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene"); //Load menu scene
    }
}
