using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public Text newScoreText, newComboText;
    private GameObject oldScore;
    float newScore,newCombo;
    // Start is called before the first frame update
    void Start()
    {
        oldScore = GameObject.Find("Score");
        newScore = oldScore.GetComponent<Scoring>().score;
        newCombo = oldScore.GetComponent<Scoring>().maxcombo;
        newScoreText.text = "Score : " + newScore.ToString("0");
        newComboText.text = "Max Combo : " + newCombo.ToString("0");
    }

}
