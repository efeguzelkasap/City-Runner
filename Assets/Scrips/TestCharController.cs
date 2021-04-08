using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    private GameObject canvas;
    float offset = .002f;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed;
        
        float vMovement = movementSpeed;
        movementSpeed += offset;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Diamond")
        {
            spawnManager.SpawnTriggerEntered();
        }

    }

    // If player collides with an obstacle then he stops moving all together.
    private void OnCollisionEnter(Collision collision)
    {
        movementSpeed = 0;
        offset = 0;
        canvas.SetActive(true);
    }
}
