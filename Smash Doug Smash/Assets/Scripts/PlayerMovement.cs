using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    private float forwardInput;
    private float turnSpeed = 70f;
    private float forwardForce = 100f;
    private float sidewaysForce = 50f;
    void Start()
    {

        

    }



    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical");
        

        playerRb.AddForce(0, 0, forwardForce * Time.deltaTime * forwardInput, ForceMode.VelocityChange);
        TurningPlayer();


    }
    
    void TurningPlayer()
    {
        
        if (Input.GetKey("a"))
        {
            playerRb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            playerRb.transform.Rotate(-Vector3.up * Time.deltaTime * turnSpeed);
        }
        if (Input.GetKey("d"))
        {
            playerRb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            playerRb.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        }




    }

}
