using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    public float turnSpeed = 500.0f;
    public float forwardForce = 1000f;
    private float horizontalInput;
    
    

    void Start()
    {
        playerRb.GetComponent<Rigidbody>();

    }



    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(0, 0, forwardForce * Time.deltaTime);
        playerRb.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
    

}
