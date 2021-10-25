 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 public class Enemy : MonoBehaviour
 {
 
     public Transform Player;
     int MoveSpeed = 20;
     int MaxDist = 10;
     int MinDist = 1;
 
 
 
 
     void Start()
     {
 



     }
 
     void Update()
     {
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             
 
         }

        else if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {

            Destroy(gameObject);




        }
    }
 }
