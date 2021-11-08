using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardInput;
    public float speed= 4000f;
    public float forwardForce = 50f;
    //public float sidewayForce = 500f;
    public float turnSpeed = 500;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(100, 200, 300);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //rb.AddForce(forwardForce * Time.deltaTime *  speed * forwardInput);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        /*//nut nut nut nut nut nut, oo oo ahh ahh monkey butt
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }*/
    }   
}
