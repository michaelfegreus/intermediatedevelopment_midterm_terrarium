using UnityEngine;
using System.Collections;

public class DirtbagController : MonoBehaviour {

	public GameObject rotateToModifier; // The hidden GameObject that will store the rotateTo Quaternion value.
	public float triggerRotationSpeed;
	Transform rotateFrom;
	Transform rotateTo;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			//rotateFrom = this.transform;
			//transform.rotation = Quaternion.Slerp (rotateFrom.rotation, rotateTo.rotation, Time.time * triggerRotationSpeed);
			transform.rotation = rotateToModifier.transform.rotation;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			//rotateFrom = this.transform;
			//transform.rotation = Quaternion.Slerp (rotateFrom.rotation, rotateTo.rotation, Time.time * triggerRotationSpeed);
			transform.rotation = Quaternion.identity;
		}
	}

	// Use this for initialization
	void Start () {
		rotateTo = rotateToModifier.transform; // I know this is a crude way to do it, please leave me be.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
