﻿using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) || Input.GetKeyDown (KeyCode.Mouse0) || Input.GetKeyDown (KeyCode.Return)) {
			Destroy (gameObject);
		}
	}
}
