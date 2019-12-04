using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public Text newScoreText;
    private GameObject oldScore;
    float newScore;
    // Start is called before the first frame update
    void Start()
    {
        oldScore = GameObject.Find("Score");
        newScore = oldScore.GetComponent<Scoring>().score;
        newScoreText.text = "Score : " + newScore.ToString("0");
    }

}
