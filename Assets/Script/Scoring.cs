using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text scoreText;
    public float score = 0;
    float tempScore = 1;

    public void incScore()
    {
        score += tempScore;
        tempScore++;
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
