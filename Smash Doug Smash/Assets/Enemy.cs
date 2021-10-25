 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class Enemy : MonoBehaviour
 {
     
     public GameObject rocketPrefab;
     public Transform Player;
     int MoveSpeed = 30;
     int MaxDist = 30;
     int MinDist = 3;
     public float flightSpeed = 50.0f;
 
 
 
 
     void Start()
     {
 



     }
 
     void Update()
     {
        transform.Translate(Vector3.up * Time.deltaTime * flightSpeed);



         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             
 
         }

        else if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {

            Instantiate(rocketPrefab, transform.position, rocketPrefab.transform.rotation);



        }
       
     }
 }
