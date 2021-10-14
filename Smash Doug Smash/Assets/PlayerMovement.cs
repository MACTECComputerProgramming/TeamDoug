using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float turnSpeed = 50f;
    public float speed = 100f;
    private float horizontalInput;
    



    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        



        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);




    }
}
