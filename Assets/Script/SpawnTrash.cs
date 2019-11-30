using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    public List<Transform> spawnPos = new List<Transform>(4) ;
    public List<GameObject> trash;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d") || Input.GetKeyDown("f") || Input.GetKeyDown("s") || Input.GetKeyDown("a"))
        {
            //int randomint = Random.Range(0, 4);
            //Instantiate(trash[randomint], spawnPos[randomint].position, spawnPos[randomint].rotation);
        }
    }
}
