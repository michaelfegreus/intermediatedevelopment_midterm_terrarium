﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody rbody; // variable to hold a reference to our rigidbody
	public float moveSpeed;

	//public GameObject testChild;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
		Cursor.visible = false;
	}

	// FixedUpdate is called once per physics frame, at a fixed framerate
	void FixedUpdate () {
		//float inputX = Input.GetAxis( "Horizontal" ); // A/D, LeftArrow/RightArrow
		//float inputY = Input.GetAxis( "Vertical" ); // W/S, UpArrow/DownArrow
		float mouseX = Input.GetAxis( "Mouse X" ); // Mouse X is the current horizontal mouse speed
		float mouseY = Input.GetAxis( "Mouse Y" ); // Mouse X is the current horizontal mouse speed

		rbody.velocity = transform.up * mouseY * moveSpeed // forward and back movement
			+ transform.right * mouseX * moveSpeed; // left and right movement
			//+ Physics.gravity; // always apply gravity
	
		/*if ( Input.GetKeyDown(KeyCode.Space) ){
			testChild.transform.SetParent (this.transform);
		}*/
	}
}