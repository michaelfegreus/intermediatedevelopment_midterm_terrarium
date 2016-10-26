using UnityEngine;
using System.Collections;

public class PlantParentController : MonoBehaviour {

	Vector3 startScale = new Vector3 (0.0008f, 0.001f, 0.001f);
	Vector3 targetScale = new Vector3 (1f, .8f, .8f);
	float speed = .03f;
	float startTime;
	float journeyLength;

	// Use this for initialization
	void Start () {
		startTime = Time.deltaTime;
		transform.localScale = startScale;
		journeyLength = Vector3.Distance (startScale, targetScale);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			transform.localScale = startScale;
			startTime = 0f;
		}
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.localScale = Vector3.Lerp (startScale, targetScale, fracJourney);
	}
}
