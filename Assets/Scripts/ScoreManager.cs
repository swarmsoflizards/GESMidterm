using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Need to reference TextMesh Pro

public class ScoreManager : MonoBehaviour
{

    [SerializeField] TMP_Text scoreLabel; //Assign UI label to points

    void Start()
    {
        scoreLabel.text = PersistentScoreManager.Instance.Score.ToString(); //Get score and send to scoreLabel
    }
}
