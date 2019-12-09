using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    private GameObject oldScore;
    void Start(){
        oldScore = GameObject.Find("Score");
        Destroy(oldScore);
    }

    void Update(){
        if(Input.GetKeyDown("r")){
            SceneManager.LoadScene("Countdown", LoadSceneMode.Single);
        }
    }
}
