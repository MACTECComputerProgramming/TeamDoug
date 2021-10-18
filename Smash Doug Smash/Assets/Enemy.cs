using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    internal int Length;
    private Rigidbody enemyRb;
    private GameObject player;
   



    // Start is called before the first frame update
    void Start()
    {

        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * Time.deltaTime * speed);


    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -1)
        {
            Destroy(gameObject);
        }



    }
}
