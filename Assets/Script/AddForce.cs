using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddForce : MonoBehaviour
{
    public List<Transform> spawnPos;
    public List<GameObject> trashes;
    const float power = 1000;
    Rigidbody rb;
    int randomint;
    enum Bin { Organic, Plastic, Glass, Electronics };

    void Start()
    {
        if (Input.GetKeyDown("d"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * power);
            rb.AddForce(Vector3.up * power);
            rb.AddForce(Vector3.right * 100);
            
        }
        else if (Input.GetKeyDown("a"))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * power);
            rb.AddForce(Vector3.up * power);
            rb.AddForce(Vector3.right * 100);
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
        }
    }

    void Update()
    {
        if (Input.GetKeyDown("d") || Input.GetKeyDown("f") || Input.GetKeyDown("s") || Input.GetKeyDown("a"))
        {
            randomint = Random.Range(0, 4);
            Instantiate(trashes[randomint], spawnPos[randomint].position, spawnPos[randomint].rotation);
        }
    }
}
