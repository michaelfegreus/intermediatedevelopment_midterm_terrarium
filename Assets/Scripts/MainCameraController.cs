using UnityEngine;
using System.Collections;

public class MainCameraController : MonoBehaviour {

	public GameObject cameraOne;
	public GameObject cameraTwo;
	public GameObject cameraThree;

	Vector3 startPos;
	Vector3 midPos;
	Vector3 endPos;

	// Use this for initialization
	void Start () {
		/*startPos = cameraOne.transform;
		midPos = cameraTwo.transform;
		endPos = cameraThree.transform;*/

		transform.position = cameraOne.transform.position;
		transform.rotation = cameraOne.transform.rotation;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
