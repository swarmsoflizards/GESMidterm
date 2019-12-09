using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToKitchen : MonoBehaviour
{

    private void OnCollisionEnter(Collision Toast) //On collision with object
    {
        if (Toast.gameObject.tag == "Toast") //If toast collides with door
        {
            print("Toast collided with door"); //Test
            UnityEngine.SceneManagement.SceneManager.LoadScene("KitchenScene"); //Load kitchen scene
        }
    }
}
