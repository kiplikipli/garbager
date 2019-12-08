using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectTrash : MonoBehaviour
{
    public GameObject score;
    public GameObject trash;

    void OnCollisionEnter(Collision col)
    {
        Scoring scoreScript = score.GetComponent<Scoring>();
        if (col.gameObject.name == trash.name + "(Clone)") {
            Destroy(col.gameObject);
            scoreScript.incScore();
            scoreScript.displayScore();
        }
        else
        {
            Destroy(col.gameObject);
            scoreScript.resetTemp();
            scoreScript.decScore();
            scoreScript.displayScore();
        }
    }
}
