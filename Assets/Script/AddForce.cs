using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddForce : MonoBehaviour
{
    public GameObject thrower;
    //public Transform[] spawnPos = new Transform[4];
    //public GameObject[] trashes = new GameObject[4];
    const float plasticPower = 1000, elecPower = 800, power=1000;
    Rigidbody rb;
    int randomint;
    enum Bin { Organic, Plastic, Glass, Electronics };
    void Start()
    {
        
        /*else if (Input.GetKeyDown("a"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * elecPower);
            rb.AddForce(Vector3.up * elecPower/2);
            rb.AddForce(Vector3.left * 200);
        }
        else if (Input.GetKeyDown("s"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * power);
            rb.AddForce(Vector3.up * power);
            rb.AddForce(Vector3.right * 100);
        }
        else if (Input.GetKeyDown("f"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * power);
            rb.AddForce(Vector3.up * power);
            rb.AddForce(Vector3.right * 100);
        }*/
    }

    void Update()
    {
        /*if (Input.GetKeyDown("d"))
        {
            randomint = Random.Range(0, 4);
            Instantiate(trashes[randomint], spawnPos[randomint].position, spawnPos[randomint].rotation);
            isSpawn = false;
        }*/
        if (Input.GetKeyDown("o")) // plastic
        {
            ThrowObject(1000f,500f,Vector3.right, 100f);
        }
        else if (Input.GetKeyDown("q")) // organic
        {
            ThrowObject(1000f, 800f, Vector3.left, 200f);
        }
        else if (Input.GetKeyDown("w")) // electronic
        {
            ThrowObject(900f, 600f, Vector3.left, 100f);
        }
        else if (Input.GetKeyDown("p")) // glass
        {
            ThrowObject(1000f, 800f, Vector3.right, 320f);
        }
    }

    void ThrowObject(float forwardPower, float upPower, Vector3 direction, float dirPower )
    {
        SpawnTrash throwerScript = thrower.GetComponent<SpawnTrash>();
        rb = throwerScript.objek.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * forwardPower,ForceMode.Force);
        rb.AddForce(Vector3.up * upPower);
        rb.AddForce(direction * dirPower);
    }
}
