using UnityEngine;
using System.Collections;

public class SetParentController : MonoBehaviour {

	Rigidbody rb;
	bool inPickupTrigger;
	GameObject player;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("PickupTrigger")) {
			inPickupTrigger = true;
		}
	}
	void OnTriggerExit(Collider col) {
		if (col.name == ("PickupTrigger")) {
			inPickupTrigger = false;
		}
	}
		
	void Start () {
		rb = GetComponent<Rigidbody>();
		inPickupTrigger = false;
		player = GameObject.Find ("Player");
	}

	void Update () {
		if ( Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)){
			if (transform.parent != null) {
				rb.isKinematic = false;
				this.transform.parent = null;
				Physics.IgnoreCollision (player.GetComponent<Collider> (), GetComponent<Collider> (), false);
			} else if ((transform.parent == null) && (inPickupTrigger)){
				rb.isKinematic = true;
				this.transform.parent = GameObject.Find ("PickupTrigger").transform;
				Physics.IgnoreCollision(player.GetComponent<Collider>(), GetComponent<Collider>());
			}
		}
	}
}
