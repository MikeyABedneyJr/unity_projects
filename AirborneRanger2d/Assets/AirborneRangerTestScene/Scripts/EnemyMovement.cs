using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMovement : MonoBehaviour {

     public float speed = 1;
     // Use this for initialization
     void Start () {
     }
	 
public float movementTimer = 2f;
public float maxSpeed = 5f;
private Vector3 movement;
private float timeLeft;
 
 void Update()
 {
   timeLeft -= Time.deltaTime;
   if(timeLeft <= 0)
   {
     movement = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
     timeLeft = movementTimer;
   }
   transform.position += movement * Time.deltaTime;
 }

}