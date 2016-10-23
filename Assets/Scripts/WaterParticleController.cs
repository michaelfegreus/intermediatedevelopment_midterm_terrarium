using UnityEngine;
using System.Collections;

public class WaterParticleController : MonoBehaviour {

	ParticleSystem water;
	bool playing;
	public static float waterTimer;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("WateringCanTrigger")) {
			water.Play();
			playing = true;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.name == ("WateringCanTrigger")) {
			water.Stop();
			playing = false;
		}
	}

	void Start () {
		water = GetComponent<ParticleSystem>();
		water.Stop ();
		playing = false;
		waterTimer = 0;
	}

	void Update () {
		if (playing) {
			waterTimer = waterTimer + Time.deltaTime;
		}
		//Debug.Log (waterTimer);
	}
}