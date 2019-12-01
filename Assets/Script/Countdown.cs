using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3.4f;
    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if(currentTime <= .5f)
        {
            SceneManager.LoadScene("Easy");
        }
        else
        {
            countdownText.text = currentTime.ToString("0");
        }
    }
}
