using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        float px = transform.position.x;
        float py = transform.position.y;
        float pz = transform.position.z;
        if (px < -xRange)
        {
            transform.position = new Vector3(-xRange, py, pz);
        }
        if (px > xRange)
        {
            transform.position = new Vector3(xRange, py, pz);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the Player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
