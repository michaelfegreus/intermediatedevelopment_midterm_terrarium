using UnityEngine;
using System.Collections;

public class DirtSpawnController : MonoBehaviour {

	public GameObject dirtPrefab;
	Vector3 pos;
	bool instantiate = false;
	int prefabLimit = 80;
	int prefabCounter;
	float timer = 0f;
	float timeLimit = .2f;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			instantiate = true;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			instantiate = false;
		}
	}

	void makeDirt(){
		Instantiate (dirtPrefab, pos, Quaternion.identity);
	}

	// Use this for initialization
	void Start () {
		pos = new Vector3 (transform.position.x, transform.position.y, 0);
		prefabCounter = prefabLimit;
	}
	
	// Update is called once per frame
	void Update () {
		pos = new Vector3 (transform.position.x, transform.position.y, 0);
		timer = timer + Time.deltaTime;
		/*if (instantiate) {
			Instantiate (dirtPrefab, pos, Quaternion.identity);
		}*/
		if (Input.GetKeyDown (KeyCode.A)) {
			Instantiate (dirtPrefab, pos, Quaternion.identity);
		}
		if ((prefabCounter > 0) && (instantiate) && (timer > timeLimit)) {
			prefabCounter--;
			timer = 0f;
			makeDirt();
		}
	}
}
 