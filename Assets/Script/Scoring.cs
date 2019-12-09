using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject timer;
    public Text scoreText, comboText;
    public float score = 0, tempScore = 0, maxcombo = 0;

    void Start()
    {

    }

    public void incScore()
    {
        Timer timerScript = timer.GetComponent<Timer>();
        score += tempScore * timerScript.currentTime;
        tempScore++;
    }

    public void displayScore()
    {
        scoreText.text = score.ToString("0");
        comboText.text = tempScore.ToString("0") + "x";
    }

    public void resetTemp()
    {
        tempScore = 0;
    }

    public void decScore()
    {
        score -= 10;
        if (score < 0)
        {
            score = 0;
        }
    }

    void Update()
    {
        if (tempScore > maxcombo)
        {
            maxcombo = tempScore;
        }
    }
}
