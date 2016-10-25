using UnityEngine;
using System.Collections;

public class MainCameraController : MonoBehaviour {

	public GameObject cameraOne;
	public GameObject cameraTwo;
	public GameObject cameraThree;
	/*public float speed = 2f;
	float startTime;
	float journeyLength;*/

	Vector3 startPos;
	Vector3 midPos;
	Vector3 endPos;

	bool started;

	public void end(){
		transform.position = cameraThree.transform.position;
		transform.rotation = cameraThree.transform.rotation;
	}

	// Use this for initialization
	void Start () {
		/*startPos = cameraOne.transform;
		midPos = cameraTwo.transform;
		endPos = cameraThree.transform;*/

		transform.position = cameraOne.transform.position;
		transform.rotation = cameraOne.transform.rotation;

		/*startTime = Time.deltaTime;
		journeyLength = Vector3.Distance (startScale, targetScale);*/

		started = false;
	}

	// Update is called once per frame
	void Update () {
		if(!started && Input.GetKey(KeyCode.Space) || !started && Input.GetKeyDown(KeyCode.Mouse0) || !started && Input.GetKeyDown(KeyCode.Return)){
			started = true;
			transform.position = cameraTwo.transform.position;
			transform.rotation = cameraTwo.transform.rotation;
		}
	}
}
/*
 * Vector3 startScale = new Vector3 (0.0008f, 0.001f, 0.001f);
	Vector3 targetScale = new Vector3 (.6f, .8f, .8f);
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
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.localScale = Vector3.Lerp (startScale, targetScale, fracJourney);
	}
}
*/
