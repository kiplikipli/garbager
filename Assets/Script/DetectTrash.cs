using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTrash : MonoBehaviour
{
    public GameObject input;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject) {
            Destroy(col.gameObject);
        }
    }
}
