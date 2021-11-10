using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(100, 200, 300);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
