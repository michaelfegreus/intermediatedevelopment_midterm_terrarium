using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour {

	//public GameObject camera;
	//MainCameraController mcc;
	//public GameObject title;

	bool started;

	// Use this for initialization
	void Start () {
		//start
		//mcc = camera.GetComponent<SeedController> ();
		started = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!started && Input.GetKey(KeyCode.Space) || !started && Input.GetKeyDown(KeyCode.Mouse0) || !started && Input.GetKeyDown(KeyCode.Return)){
			started = true;
			//Destroy (title);
			Destroy(GameObject.Find ("WaterHole"));
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			WaterParticleController.waterTimer = 0f;
			SceneManager.LoadScene (0);
		}
	}
}
