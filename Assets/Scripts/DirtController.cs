using UnityEngine;
using System.Collections;

public class DirtController : MonoBehaviour {

	float lifetimeTimer = 5f;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("DirtCylinder")) {
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifetimeTimer = lifetimeTimer - Time.deltaTime;
		if (lifetimeTimer < 0) {
			Destroy (gameObject);
		}
	}
}
