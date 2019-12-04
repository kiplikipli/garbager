using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    public bool isSpawn=true;
    public GameObject objek;
    public Transform[] spawnPos = new Transform[4];
    public GameObject[] trashes = new GameObject[4];
    public int randomint;

    // Update is called once per frame
    void Update()
    {
        if (isSpawn == true)
        {
            randomint = Random.Range(0, 4);
            objek = Instantiate(trashes[randomint], spawnPos[randomint].position, spawnPos[randomint].rotation);
            isSpawn = false;
        }
        if (Input.GetKeyDown("q") || Input.GetKeyDown("w") || Input.GetKeyDown("o") || Input.GetKeyDown("p"))
        {
            isSpawn = true;
        }
    }
}
