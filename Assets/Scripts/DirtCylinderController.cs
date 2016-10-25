using UnityEngine;
using System.Collections;

public class DirtCylinderController : MonoBehaviour {

	float scaleY = 7f;
	public float scaling;
	Renderer rend;

	/*Color drySoil;
	Color wetSoil;
	Color currentColor;
	float storedWaterTimer;*/

	void OnTriggerEnter(Collider col) {
		if (col.tag == ("Dirt")) {
			if (rend.enabled == false) {
				rend.enabled = true;
				//rend.material.color = drySoil;
			}
			scaleY = scaleY + scaling;
			transform.localScale = new Vector3(51f, scaleY,51f);
		}
	}

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = false;

		/*drySoil = new Color (94f, 65f, 65f);
		wetSoil = new Color (0f, 0f, 0f);
		currentColor = drySoil;
		storedWaterTimer = 0f;
		//rend.material.color = drySoil;*/
	}
	
	// Update is called once per frame
	void Update () {
		/*if (storedWaterTimer < WaterParticleController.waterTimer) {
			//currentColor = Color.Lerp (drySoil, wetSoil, Time.deltaTime);
			//rend.material.color = currentColor;

		}
		storedWaterTimer = WaterParticleController.waterTimer;*/
		//currentColor = Color.Lerp (drySoil, wetSoil, Time.deltaTime * 10f);
		//rend.material.color = currentColor;
		/*if (1.5f < WaterParticleController.waterTimer && WaterParticleController.waterTimer < 3.0f) {
			rend.material.color = new Color (84f, 60f, 60f);
		}*/
		//rend.material.color = Color.LerpUnclamped (Color.white, Color.black, Time.deltaTime);
	}
}
