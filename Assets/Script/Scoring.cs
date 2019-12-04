using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject timer;
    public Text scoreText;
    public float score = 0;
    float tempScore = 1;

    void Start()
    {
            
    }

    public void incScore()
    {
        Timer timerScript = timer.GetComponent<Timer>();
        score += tempScore*timerScript.currentTime;
    }

    public void displayScore()
    {
        scoreText.text = score.ToString("0");
    }

    public void resetTemp()
    {
        tempScore = 1;
    }
}
