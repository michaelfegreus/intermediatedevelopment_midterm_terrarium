using UnityEngine;
using System.Collections;

public class SetParentController : MonoBehaviour {

	Rigidbody rb;
	bool clicked;

	void OnTriggerStay(Collider col) {
		//Debug.Log ("Trigger detected.");
		if ( Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0) ){
			if ((rb.isKinematic) || (transform.parent != null)){ //Puts down if already holding this object
				rb.isKinematic = false;
				this.transform.parent = null;
				Physics.IgnoreCollision(col.GetComponent<Collider>(), GetComponent<Collider>(), false); // Enables Player tweezers and item collisions again.
			} else {
				rb.isKinematic = true; //Picks up if not holding this object
				this.transform.parent = GameObject.Find ("Player").transform;
				Physics.IgnoreCollision(col.GetComponent<Collider>(), GetComponent<Collider>()); // Prevents Player tweezers from colliding with the items and preventing movement.
				/*if(this.name == ("Dirtbag")){
					transform.rotation = Quaternion.identity;
				}*/
			}
		}
	}

	/*void OnTriggerExit(Collider col){
		rb.isKinematic = false;
		this.transform.parent = null;
		Physics.IgnoreCollision(col.GetComponent<Collider>(), GetComponent<Collider>(), false);
	}*/

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		clicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Mouse0)) {
			if (transform.parent != null) {
				rb.isKinematic = false;
				Physics.IgnoreCollision (transform.parent.GetComponent<Collider> (), GetComponent<Collider> (), false);
				this.transform.parent = null;
			}
		}*/
		if ( Input.GetKey(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)){
			clicked = true;
		}
	}
}
