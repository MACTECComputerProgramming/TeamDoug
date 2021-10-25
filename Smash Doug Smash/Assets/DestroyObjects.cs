using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{

    //Destroys objects it touches
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
