using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 30f;
    [SerializeField] Text timerText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if(currentTime <= 0)
        {
            DontDestroyOnLoad(GameObject.Find("Score"));
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            timerText.text = currentTime.ToString("0");
        }
    }
}
