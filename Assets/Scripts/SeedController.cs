using UnityEngine;
using System.Collections;

public class SeedController : MonoBehaviour {
	
	bool dirtSatisfied = false;
	bool waterSatisfied = false;
	bool corkSatisfied = false;

	public void seedTrigger(){
		dirtSatisfied = true;
	}

	public void waterTrigger(){
		waterSatisfied = true;
	}

	public void corkTrigger(){
		corkSatisfied = true;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (4f < WaterParticleController.waterTimer &&  WaterParticleController.waterTimer < 7f) {
			waterSatisfied = true;
		}
	}
}
