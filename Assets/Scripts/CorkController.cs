﻿using UnityEngine;
using System.Collections;

public class CorkController : MonoBehaviour {

	bool inTrigger;
	public GameObject seed;
	SeedController sc;

	public GameObject corkLock;
	//Vector3 lockPos;

	void OnTriggerEnter(Collider col){
		if (col.name == ("CorkTrigger")) {
			inTrigger = true;
			transform.rotation = Quaternion.identity;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.name == ("CorkTrigger")) {
			inTrigger = false;
			sc.corkTrigger (false);
		}
	}

	// Use this for initialization
	void Start () {
		sc = seed.GetComponent<SeedController> ();
		inTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (inTrigger) {
			if (Input.GetKey (KeyCode.Space) || Input.GetKeyDown (KeyCode.Mouse0)) {
				sc.corkTrigger (true);
				corkLock.GetComponent<Renderer> ().enabled = true;
				Destroy (gameObject);
				/*if (transform.parent != null) {
				transform.parent = null;
			}*/
			}
		}
	}
}
