using UnityEngine;
using System.Collections;

public class WateringCanController : MonoBehaviour {

	float timer = 0f;
	float rotateTimeLimit = .1f;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("WateringCanTrigger")) {
			timer = 0f;
			transform.eulerAngles = new Vector3 (30f, -90f, 0f); // If time, go back and re-export the watering can model rotated -90 so you can remove the -90f value here.
		}
	}

	void OnTriggerStay(Collider col){
		if (timer < rotateTimeLimit) {
			timer = timer + Time.deltaTime;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("WateringCanTrigger")) {
			if(timer > rotateTimeLimit){
				transform.eulerAngles = new Vector3 (0f, -90f, 0f); // Switch this to Quaternion.identity if time to re-export FBX
				timer = 0f;
			}
		}
	}
}