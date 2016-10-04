using UnityEngine;
using System.Collections;

public class SetParentController : MonoBehaviour {

	public Rigidbody rb;

	void OnTriggerStay(Collider col) {
		Debug.Log ("Trigger detected.");
		if ( Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0) ){
			if (rb.isKinematic) { //Puts down if already holding this object
				rb.isKinematic = false;
				this.transform.parent = null;
				Physics.IgnoreCollision(col.GetComponent<Collider>(), GetComponent<Collider>(), false); // Enables Player tweezers and item collisions again.
			} else {
				rb.isKinematic = true; //Picks up if not holding this object
				this.transform.parent = GameObject.Find ("Player").transform;
				Physics.IgnoreCollision(col.GetComponent<Collider>(), GetComponent<Collider>()); // Prevents Player tweezers from colliding with the items and preventing movement.
			}
		}
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
