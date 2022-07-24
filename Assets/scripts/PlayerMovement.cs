﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce= 500f;

	// Use this for initialization
	void Start () {
//		Debug.Log ("Hello world");
		rb.useGravity = true;
	//	rb.AddForce(0,200,500);
	}

	//we use variables for 

	// Update is called once per frame
	void FixedUpdate () {

		//add a forward force 

		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d")){
			rb.AddForce (sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			//only executed if condition is met 
		}
		if(Input.GetKey("a")){
			rb.AddForce (-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			//only executed if condition is met 
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
