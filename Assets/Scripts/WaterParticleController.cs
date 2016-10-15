using UnityEngine;
using System.Collections;

public class WaterParticleController : MonoBehaviour {

	ParticleSystem water;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			
			water.Play();
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("DirtSpawnerTrigger")) {
			water.Stop();
		}
	}

	void Start () {
		water = GetComponent<ParticleSystem>();
	}
}