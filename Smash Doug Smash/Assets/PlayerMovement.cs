using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    private float turnSpeed = 10f;
    private float speed = 1f;
    private float horizontalInput;
    private float verticalInput;
    

    void Start()
    {

        playerRb.GetComponent<Rigidbody>();

    }



    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        playerRb.transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        playerRb.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
    

}
