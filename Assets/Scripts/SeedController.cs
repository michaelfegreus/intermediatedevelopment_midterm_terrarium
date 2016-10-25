using UnityEngine;
using System.Collections;

public class SeedController : MonoBehaviour {
	
	bool dirtSatisfied = false;
	bool dirtDrown = false;
	bool waterSatisfied = false;
	bool waterDrown = false;
	bool corkSatisfied = false;
	bool inJar = false;
	bool spaceSatisfied = false;

	Vector3 pos;
	public GameObject plantPrefab;

	public Material black;

	public void dirtTrigger(){
		dirtDrown = true;
	}

	public void dirtSatisfiedTrigger(){
		dirtSatisfied = true;
	}

	public void corkTrigger(bool placed){
		corkSatisfied = placed;
	}

	public void growingPhase(){
		Destroy (GameObject.FindGameObjectWithTag ("Player"));
		if (dirtSatisfied && !dirtDrown && waterSatisfied && !waterDrown && spaceSatisfied) {
			Debug.Log ("Plant lives");
			pos = new Vector3 (transform.position.x, transform.position.y, 0);
			Instantiate (plantPrefab, pos, Quaternion.identity);
			Destroy (gameObject);
		} else {
			Debug.Log ("Plant dies");
			GetComponent<Renderer> ().material = black;
			GameObject.Find ("SeedLeaf").GetComponent<Renderer> ().material = black;
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.name == ("SeedInJarTrigger")) {
			inJar = true;
		}
		if (col.name == ("SeedInJarTrigger")) {
			spaceSatisfied = true;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("SeedSurviveTrigger")) {
			inJar = false;
		}
		if (col.name == ("SeedSurviveTrigger")) {
			spaceSatisfied = false;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (4f < WaterParticleController.waterTimer && WaterParticleController.waterTimer < 7f) {
			waterSatisfied = true;
			Debug.Log ("Water satisfied");
		} else if (7f < WaterParticleController.waterTimer) {
			waterDrown = true;
		}
		if (corkSatisfied && inJar) {
			growingPhase ();
		}
	}
}
