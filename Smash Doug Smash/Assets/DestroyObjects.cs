using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{

    //Destroys objects it touches
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        else if (other.tag == "Enemy")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
        
        
        
        
        
    }
}
