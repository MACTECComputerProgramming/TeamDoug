using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    // Detects collisions
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Enemy")
        {
            Destroy(player);
            Destroy(enemy);


        }





    }

}
