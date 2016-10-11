using UnityEngine;
using System.Collections;

public class DirtbagController : MonoBehaviour {

	public GameObject rotateToModifier; // The hidden GameObject that will store the rotateTo Quaternion value.
	public float triggerRotationSpeed;
	Transform rotateFrom;
	Transform rotateTo;
	float timer = 0f;
	float rotateTimeLimit = .1f;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			//rotateFrom = this.transform;
			//transform.rotation = Quaternion.Slerp (rotateFrom.rotation, rotateTo.rotation, Time.time * triggerRotationSpeed);
			//transform.rotation = rotateToModifier.transform.rotation;
			//transform.Translate(0f, -1f, 0f);
			timer = 0f;
			transform.eulerAngles = new Vector3 (0f, 0f, 130f);
		}
	}

	void OnTriggerStay(Collider col){
		if (timer < rotateTimeLimit) {
			timer = timer + Time.deltaTime;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			//rotateFrom = this.transform;
			//transform.rotation = Quaternion.Slerp (rotateFrom.rotation, rotateTo.rotation, Time.time * triggerRotationSpeed);
				if(timer > rotateTimeLimit){
					transform.rotation = Quaternion.identity;
					timer = 0f;
				}
		}
	}

	// Use this for initialization
	void Start () {
		//rotateTo = rotateToModifier.transform; // I know this is a crude way to do it, please leave me be.
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (timer);
	}
}
