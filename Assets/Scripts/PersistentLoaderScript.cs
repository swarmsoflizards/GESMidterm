using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentLoaderScript : MonoBehaviour
{
    public static PersistentLoaderScript Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
