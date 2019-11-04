using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        EditorSceneManager.LoadScene("GameScene"); //Load game scene
    }

    public void LoadMenuScene()
    {
        EditorSceneManager.LoadScene("MenuScene"); //Load menu scene
    }
}
