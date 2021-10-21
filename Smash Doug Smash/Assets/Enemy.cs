using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    internal int Length;
    private GameObject player;
   



    // Start is called before the first frame update
    void Start()
    {


        player = GameObject.Find("Player");

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        transform.Translate(lookDirection * Time.deltaTime * speed);


    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other == GameObject.Find("Player"))
        {
            Destroy(gameObject);

            Destroy(GameObject.Find("Player"));

            Debug.Log("Game Over");

        }
        else if (other != GameObject.Find("Player"))
        {

            Debug.Log("You will die soon!!!");



        }


    }

}
